using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using svietnamAPI.Common.Dtos.Catalog.Product;
using svietnamAPI.Common.Dtos.Values;
using svietnamAPI.Common.Dtos.Responses;
using svietnamAPI.Models.IServices;
using svietnamAPI.Controllers.Filters;

namespace svietnamAPI.Controllers.Catalog
{
    public class ProductController : AppControllerBase
    {
        public ProductController(IServiceWrapper serviceWrapper, 
            ILogger<CategoryController> logger)
        : base(serviceWrapper, logger)
        {
        }

        [HttpGet(RouteConst.Products_GetAll)]
        public async Task<ActionResult<List<ProductDto>>> GetAll()
        {
            var products = await _serviceWrapper.ProductService
                                                    .GetAllAsync<ProductDto>(isIncludeProductItem: true,
                                                                                isIncludeProductItemDetail: true,
                                                                                isIncludeEavValue: true);
            var res = new SuccessResponse<List<ProductDto>>(60001, 
                                                                products, 
                                                                ResponseCodeConst.S60001);
            return Ok(res);
        }
    }
}