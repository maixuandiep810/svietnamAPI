using System.Reflection.Metadata;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using svietnamAPI.Common.Helpers;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.StaticFileContext;
using svietnamAPI.Models.IRepositories.AppStaticFile;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Models.Repositories.AppStaticFile
{
    public class StaticFileRepository : IStaticFileRepository
    {

        private readonly AppStaticFileContext _appStaticFileContext;
        private readonly ILogger<StaticFileRepository> _logger;

        public StaticFileRepository(AppStaticFileContext appStaticFileContext,
            ILogger<StaticFileRepository> logger)
        {
            _appStaticFileContext = appStaticFileContext;
            _logger = logger;
        }

        public async Task<DocumentCreateDto> WriteStaticFileAsync(RelativeLocationOfStaticFileFolderEnum relLocation,
            IFormFile sourceFormFile)
        {
            //
            var fullFilename = ContentDispositionHeaderValue.Parse(sourceFormFile.ContentDisposition).FileName.Trim('"'); // Delete "" in Content-Disposition
            var fileExtension = Path.GetExtension(fullFilename);
            var filename = $"{GuidHepler.GenerateGuid()}{fileExtension}";
            var destStaticFileInfo = await _appStaticFileContext.WriteStaticFileAsync(sourceFormFile.OpenReadStream(), relLocation, filename);
            //
            int destDocumentTypeId = 0;
            if (string.Equals(fileExtension, DocumentTypeConst.Image_jpeg.Extension))
            {
                destDocumentTypeId = DocumentTypeConst.Image_jpeg.Id;
            }
            else if (string.Equals(fileExtension, DocumentTypeConst.Image_jpg.Extension))
            {
                destDocumentTypeId = DocumentTypeConst.Image_jpg.Id;
            }
            else if (string.Equals(fileExtension, DocumentTypeConst.Image_png.Extension))
            {
                destDocumentTypeId = DocumentTypeConst.Image_png.Id;
            }
            //
            var documentCreateDto = new DocumentCreateDto
            {
                Name = destStaticFileInfo.fileName,
                DisplayName = destStaticFileInfo.fileName,
                Location = destStaticFileInfo.location,
                Url = destStaticFileInfo.url,
                DocumentTypeId = destDocumentTypeId
            };
            return documentCreateDto;
        }
    }
}