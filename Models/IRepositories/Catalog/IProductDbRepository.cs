using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IRepositories.Catalog
{
    public interface IProductDbRepository : IGenericDbRepository<Product, int>
    {
        Task<List<Product>> GetFullAllOrNullAsync(bool shouldIncludeProductItem);
    }
}