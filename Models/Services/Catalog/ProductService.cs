using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;

namespace svietnamAPI.Models.Services.Catalog
{
    public class ProductService : GenericService<Product, int, IProductDbRepository, ProductDto>,
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

        public async Task<List<ProductDto>> GetFullAllOrNullAsync(bool shouldIncludeProductItem)
        {
            var productEntites = await _tDbRepo.GetFullAllOrNullAsync(shouldIncludeProductItem);
            var productDtos = _mapper.Map<List<ProductDto>>(productEntites);
            return productDtos;
        }
    }
}