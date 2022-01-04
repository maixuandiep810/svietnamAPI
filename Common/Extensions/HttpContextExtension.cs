using System.Text.Json;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.Responses;
using Microsoft.AspNetCore.Http;

namespace svietnamAPI.Helper.Extensions
{
    public static class HttpContextExtension
    {
        public static async Task WriteApplicationJsonAsync(this HttpResponse httpResponse, int statusCode, object bodyContent)
        {
            httpResponse.StatusCode = statusCode;
            httpResponse.ContentType = "application/json";
            var bodyJson = JsonSerializer.Serialize(bodyContent);
            await httpResponse.WriteAsync(bodyJson);
        }

        public static async Task WriteErrorResponseAsync(this HttpResponse httpResponse, int statusCode, int responseCode, string message, string stackTrace = null, string exceptionMessage = null)
        {
            var errorResponse = new ErrorResponse(responseCode, message, stackTrace, exceptionMessage);
            await httpResponse.WriteApplicationJsonAsync(statusCode, errorResponse);
        }


    }
}