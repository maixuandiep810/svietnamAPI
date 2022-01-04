using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using svietnamAPI.Common.Dtos.Catalog;
using svietnamAPI.Common.Dtos.Values;
using svietnamAPI.Common.Dtos.Responses;
using svietnamAPI.Models.IServices;
using svietnamAPI.Controllers.Filters;

namespace svietnamAPI.Controllers.Catalog
{
    public class CategoryController : AppControllerBase
    {
        public CategoryController(IServiceWrapper serviceWrapper, ILogger<CategoryController> logger)
        : base(serviceWrapper, logger)
        {
        }

        [HttpGet(RouteConst.Categories_GetAll)]
        public async Task<ActionResult<List<CategoryDto>>> GetAll()
        {
            var categories = await _serviceWrapper.CategoryService.GetAllAsync<CategoryDto>(isIncludeImage: true);
            var res = new SuccessResponse<List<CategoryDto>>(60001, categories, ResponseCodeConst.S60001);
            return Ok(res);
        }

        [HttpGet(RouteConst.Categories_Detail)]
        public async Task<ActionResult<CategoryDto>> Detail(int categoryId)
        {
            var category = await _serviceWrapper.CategoryService.GetByIdAsync<CategoryDto>(categoryId);
            var res = new SuccessResponse<CategoryDto>(60001, category, ResponseCodeConst.S60001);
            return Ok(res);
        }

        [HttpPost(RouteConst.Categories_Create)]
        [ValidateFilter]
        public async Task<ActionResult<CategoryDto>> Create([FromBody] CreateCategoryDto createCategoryDto)
        {
            await _serviceWrapper.CategoryService.CreateAsync(createCategoryDto);
            var res = new SuccessResponse<bool>(62001, true, ResponseCodeConst.S62001);
            return Ok(res);
        }
    }
}