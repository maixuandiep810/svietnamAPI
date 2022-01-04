using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IServices.Catalog
{
    public interface ICategoryService : IGenericService<Category, int>
    {
        Task<List<TDto>> GetAllAsync<TDto>(bool isIncludeImage)
            where TDto : class;
        Task CreateAsync(CreateCategoryDto createCategoryDto);
    }
}