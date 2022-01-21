using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using svietnamAPI.StartupConfig.AppSettingConfig;

namespace svietnamAPI.Infras.Data.StaticFileContext
{
    public class AppStaticFileContext
    {
        private readonly ServerSetting _serverSetting;
        private readonly List<string> _locationOfAddedStaticFile;

        public AppStaticFileContext(IOptions<ServerSetting> serverSetting)
        {
            _serverSetting = serverSetting.Value;
            _locationOfAddedStaticFile = new List<string>();
        }

        public async Task<(string fileName, string location, string url)> WriteStaticFileAsync(Stream sourceFileStream, RelativeLocationOfStaticFileFolderEnum relLocation, string destFileName)
        {
            // Step1.
            string destFolderLocation = "";
            Uri destFolderUrl = null;
            switch (relLocation)
            {
                case RelativeLocationOfStaticFileFolderEnum.GlobalProductCategoryImage:
                    destFolderLocation = _serverSetting.StaticFile.GlobalProductCategoryImageLocation;
                    destFolderUrl = new Uri(_serverSetting.StaticFile.GlobalProductCategoryImageUrl);
                    break;
                default:
                    break;
            }
            var destFileLocation = Path.Combine(destFolderLocation, destFileName);
            var destFileUrl = new Uri(destFolderUrl, destFileName);

            // Step2.
            Stream destFileStream = new FileStream(destFileLocation, FileMode.Create);
            using (sourceFileStream)
            using (destFileStream)
            {
                await sourceFileStream.CopyToAsync(destFileStream);
            }

            // Step3.
            _locationOfAddedStaticFile.Add(destFileLocation);

            var result = (fileName: destFileName, location: destFileLocation, url: destFileUrl.ToString());
            return result;
        }

        public async Task RollBackWriteStaticFileAsync()
        {
            foreach (var fileLocation in _locationOfAddedStaticFile)
            {
                if (File.Exists(fileLocation))
                {
                    try
                    {
                        await Task.Run(() => { File.Delete(fileLocation); });
                    }
                    catch
                    {
                    }
                }

            }
        }

        public void PrepareStaticFilesFolder()
        {
            CreateRelativeStaticFileFolderIfNotExits(_serverSetting.StaticFile.BaseLocation);
            CreateRelativeStaticFileFolderIfNotExits(_serverSetting.StaticFile.GlobalProductCategoryImageLocation);
        }

        private void CreateRelativeStaticFileFolderIfNotExits(string relativePath)
        {
            if (!Directory.Exists(relativePath))
            {
                Directory.CreateDirectory(relativePath);
            }
        }
    }
}