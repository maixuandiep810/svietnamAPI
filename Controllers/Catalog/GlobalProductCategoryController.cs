using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using svietnamAPI.Common.Dtos.Values;
using svietnamAPI.Common.Dtos.Responses;
using svietnamAPI.Models.IServices;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;

namespace svietnamAPI.Controllers.Catalog
{
    public class GlobalProductCategoryController : AppControllerBase
    {
        public GlobalProductCategoryController(IServiceWrapper serviceWrapper, ILogger<GlobalProductCategoryController> logger)
        : base(serviceWrapper, logger)
        {
        }

        [HttpGet(RouteConst.GlobalProductCategories_GetDetailAll)]
        public async Task<ActionResult> GetDetailAll()
        {
            var globalPCDtos = await _serviceWrapper.GlobalProductCategoryService.GetDetailAllOrNullAsync(shouldIncludeImage: true);
            var res = new SuccessResponse<List<GlobalProductCategoryDto>>(60001, globalPCDtos, ResponseCodeConst.S60001);
            return Ok(res);
        }

        [HttpGet(RouteConst.GlobalProductCategories_GetDetailById)]
        public async Task<ActionResult> GetDetailById(int gpcId)
        {
            var globalPCDto = await _serviceWrapper.GlobalProductCategoryService.GetDetailByIdOrNullAsync(gpcId, shouldIncludeImage: true);
            var res = new SuccessResponse<GlobalProductCategoryDto>(60001, globalPCDto, ResponseCodeConst.S60001);
            return Ok(res);
        }

        [HttpGet(RouteConst.GlobalProductCategories_GetSummaryAll)]
        public async Task<ActionResult> GetSummaryAll()
        {
            var globalPCDtos = await _serviceWrapper.GlobalProductCategoryService.GetSummaryAllOrNullAsync();
            var res = new SuccessResponse<List<GlobalProductCategorySummaryDto>>(60001, globalPCDtos, ResponseCodeConst.S60001);
            return Ok(res);
        }

        [HttpPost(RouteConst.GlobalProductCategories_Create)]
        // [ValidateFilter]
        public async Task<ActionResult> Create([FromForm] GlobalProductCategoryCreateDto createCategoryDto)
        {
            await _serviceWrapper.GlobalProductCategoryService.CreateAsync(createCategoryDto);
            var res = new SuccessResponse<bool>(62001, true, ResponseCodeConst.S62001);
            return Ok(res);
        }
    }
}