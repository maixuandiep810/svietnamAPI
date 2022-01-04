// using System.Collections.Generic;
// using System.Linq;
// using System;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Filters;
// using svietnamAPI.Dtos.Auth;
// using svietnamAPI.Dtos.ApiResponse;
// using svietnamAPI.Services.Interfaces;
// using Microsoft.Extensions.DependencyInjection;
// using svietnamAPI.Dtos.ValueDtos;
// using System.Threading.Tasks;
// using svietnamAPI.Helper.Exceptions;
// using svietnamAPI.Helper.Extensions;

// namespace svietnamAPI.Helper.Filters
// {
//     [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
//     public class EndpointAsyncFilterAttribute : Attribute, IAsyncAuthorizationFilter
//     {
//         private readonly string _endpointCode;

//         public EndpointAsyncFilterAttribute(EndpointCodeType endpointCode)
//         {
//             _endpointCode = endpointCode.ToString();
//         }


//         public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
//         {
//             var endpointPermission = await CheckEndpointPermission(context.HttpContext, _endpointCode);

//             if (checkPermission.IsAuthenticated == false)
//             {
//                 // not logging in
//                 var errorResult = new JsonResult(StatusCodes.Status401Unauthorized);
//                 errorResult.SetErrorResult(11002, ResponseCodeConst.E11002);
//                 context.Result = errorResult;
//                 return;
//             }
//             else if (checkPermission.IsAuthorized == false)
//             {
//                 // not logging in
//                 var errorResult = new JsonResult(StatusCodes.Status401Unauthorized);
//                 errorResult.SetErrorResult(11003, ResponseCodeConst.E11003);
//                 context.Result = errorResult;
//                 return;
//             }

//             context.HttpContext.Items[HttpContextConst.Items_PermissionOfAction] = checkPermission.CombinedPermission;
//         }

//         private async Task<(bool IsAuthenticated, bool IsAuthorized)> CheckEndpointPermission(HttpContext httpContext, string endpointCode)
//         {
//             try
//             {
//                 var endpointService = httpContext.RequestServices.GetService<IEndpointService>();
//                 var userClaims = httpContext.User;
//                 var groupCode = userClaims.FindFirst(ClaimInfo.GroupCode)?.Value.ToString();
//                 var roleCodes = userClaims.FindFirst(ClaimInfo.RoleCodes)?.Value.ToString().Split(AuthValueConst.RoleCodesSeperator).ToList();
//                 var endpoints = await endpointService.GetEndpoint_ByCode_Role_Async(endpointCode, roleCodes);
//                 if (endpoints == null)
//                 {
//                     if (groupCode.Equals(AuthValueConst.GuestGroupCode) == true)
//                         return (IsAuthenticated: false, IsAuthorized: false);
//                     else
//                         return (IsAuthenticated: true, IsAuthorized: false);
//                 }
//                 return (IsAuthenticated: true, IsAuthorized: true);
//             }
//             catch (System.Exception ex)
//             {
//                 throw new AppSystemException(ex);
//             }
//         }

//     }



// }
