using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.Catalog.Product;

namespace svietnamAPI.Models.Services.Catalog
{
    public class ProductService : GenericService<Product, int, IProductDbRepository>,
        IProductService
    {
        public ProductService(IMapper mapper,
            IUnitOfWork unitOfWork,
            IServiceWrapper serviceWrapper,
            ILogger logger)
        : base(mapper,
            unitOfWork,
            unitOfWork.ProductDbRepo,
            serviceWrapper,
            logger)
        {

        }

        public async Task<List<TDto>> GetAllAsync<TDto>(bool isIncludeProductItem,
            bool isIncludeProductItemDetail,
            bool isIncludeEavValue)
            where TDto : ProductDto
        {
            var productEntites = await _tDbRepo.GetAllAsync(isIncludeProductItem,
                isIncludeProductItemDetail,
                isIncludeEavValue);
            var productDtos = _mapper.Map<List<TDto>>(productEntites);
            return productDtos;
        }
    }
}