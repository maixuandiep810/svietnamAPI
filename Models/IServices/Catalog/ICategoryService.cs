using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.Catalog.Category;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IServices.Catalog
{
    public interface ICategoryService : IGenericService<Category, int>
    {
        Task<List<TDto>> GetAllAsync<TDto>(bool isIncludeImage)
            where TDto : CategoryDto;
        Task CreateAsync(CreateCategoryDto createCategoryDto);
        Task SoftDeleteAsync(int entityId);
    }
}