using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using svietnamAPI.Common.Exceptions;
using svietnamAPI.Helper.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace svietnamAPI.Controllers.Middlewares
{
    public class UnhandledExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<UnhandledExceptionMiddleware> _logger;

        public UnhandledExceptionMiddleware(RequestDelegate next, IWebHostEnvironment env, ILogger<UnhandledExceptionMiddleware> logger)
        {
            _next = next;
            _env = env;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                _logger.LogError(error.StackTrace);

                var statusCode = 0;
                var responseCode = 0;
                var message = "";
                string stackTrace = null;
                string exceptionMessage = null;
                switch (error)
                {
                    // not found error
                    case KeyNotFoundException e:
                        statusCode = (int)HttpStatusCode.NotFound;
                        break;
                    // unhandled error
                    case UncategorizedErrorAppException e:
                        statusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                    default:
                        // unhandled error
                        statusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                if (_env.IsDevelopment() == true)
                {
                    stackTrace = error.StackTrace;
                    exceptionMessage = error.Message;
                }

                await context.Response.WriteErrorResponseAsync(statusCode, responseCode, message);
            }
        }

    }
}
