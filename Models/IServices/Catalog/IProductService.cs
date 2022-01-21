using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IServices.Catalog
{
    public interface IProductService : IGenericService<Product, int, ProductDto>
    {
        Task<List<ProductDto>> GetFullAllOrNullAsync(bool shouldIncludeProductItem);

    }
}