using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IRepositories.Catalog
{
    public interface ICategoryDbRepository : IGenericDbRepository<Category, int>
    {
        Task SoftDeleteAsync(int entityId);
        Task<List<Category>> GetAllAsync(bool isIncludeImage);
    }
}