using svietnamAPI.Common.Dtos.Responses;
using Microsoft.AspNetCore.Mvc;

namespace svietnamAPI.Helper.Extensions
{
    public static class JsonResultExtension
    {
        public static void SetErrorResult(this JsonResult jsonResult, int responseCode, string message, string stackTrace = null, string exceptionMessage = null)
        {
            var resBody = new ErrorResponse(responseCode,message, null, null);
            jsonResult.Value = resBody;
        }
    }
}