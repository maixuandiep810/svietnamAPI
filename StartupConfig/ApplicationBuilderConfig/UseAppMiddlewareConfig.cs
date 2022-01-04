using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using svietnamAPI.Controllers.Middlewares;
using svietnamAPI.StartupConfig.AppSettingConfig;

namespace svietnamAPI.StartupConfig.ApplicationBuilderConfig
{
    public static class UseAppMiddlewareConfig
    {
        public static void UseUnhandledException(this IApplicationBuilder app)
        {
            app.UseMiddleware<UnhandledExceptionMiddleware>();
        }
    }
}