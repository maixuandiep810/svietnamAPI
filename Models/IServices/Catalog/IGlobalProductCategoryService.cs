using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IServices.Catalog
{
    public interface IGlobalProductCategoryService : IGenericService<GlobalProductCategory, int, GlobalProductCategoryDto>
    {
        Task<List<GlobalProductCategorySummaryDto>> GetSummaryAllOrNullAsync();
        Task<GlobalProductCategorySummaryDto> GetSummaryByIdOrNullAsync(int gpcId);
        Task<GlobalProductCategoryDto> GetDetailByIdOrNullAsync(int gpcId, 
            bool shouldIncludeImage);
        Task<List<GlobalProductCategoryDto>> GetDetailAllOrNullAsync(bool shouldIncludeImage);
        Task CreateAsync(GlobalProductCategoryCreateDto createDto);
    }
}