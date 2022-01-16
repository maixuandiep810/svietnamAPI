using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IRepositories.Catalog
{
    public interface IGlobalProductCategoryDbRepository : IGenericDbRepository<GlobalProductCategory, int>
    {
        Task SoftDeleteAsync(int entityId);
        Task<List<GlobalProductCategory>> GetAllAsync(bool isIncludeImage);
    }
}