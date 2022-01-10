using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.Catalog.Product;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IServices.Catalog
{
    public interface IProductService : IGenericService<Product, int>
    {
        Task<List<TDto>> GetAllAsync<TDto>(bool isIncludeProductItem,
            bool isIncludeProductItemDetail,
            bool isIncludeEavValue)
            where TDto : ProductDto;
    }
}