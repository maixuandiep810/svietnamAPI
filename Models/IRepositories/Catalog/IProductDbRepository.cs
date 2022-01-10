using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IRepositories.Catalog
{
    public interface IProductDbRepository : IGenericDbRepository<Product, int>
    {
        Task SoftDeleteAsync(int entityId);
        Task<List<Product>> GetAllAsync(bool isIncludeProductItem,
            bool isIncludeProductItemDetail,
            bool isIncludeEavValue);
    }
}