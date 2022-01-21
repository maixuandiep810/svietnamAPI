using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;
using svietnamAPI.Common.Helpers;
using svietnamAPI.Infras.Data.StaticFileContext;

namespace svietnamAPI.Models.IRepositories.AppStaticFile
{
    public interface IStaticFileRepository
    {
        Task<DocumentCreateDto> WriteStaticFileAsync(RelativeLocationOfStaticFileFolderEnum relLocation, 
            IFormFile sourceFormFile);
    }
}