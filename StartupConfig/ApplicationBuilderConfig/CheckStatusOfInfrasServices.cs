using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.Infras.Data.StaticFileContext;

namespace svietnamAPI.StartupConfig.ApplicationBuilderConfig
{
    public static class PrepareInfrasServicesConfig
    {
        public static void PrepareInfrasServices(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope()) { 
            // TODO:
            // 1. AppDbContext
            var appDbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            // 2. StaticFileContext
            var appStaticFileContext = scope.ServiceProvider.GetRequiredService<AppStaticFileContext>();
            //
            appStaticFileContext.PrepareStaticFilesFolder();
            }
        }
    }
}