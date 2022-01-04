using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using svietnamAPI.StartupConfig.AppSettingConfig;

namespace svietnamAPI.StartupConfig.ApplicationBuilderConfig
{
    public static class UseAppStaticFilesConfig
    {
        public static void UseAppStaticFiles(this IApplicationBuilder app)
        {
            var serverSetting = (app.ApplicationServices.GetRequiredService<IOptions<ServerSetting>>()).Value;
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(serverSetting.StaticFile.BaseLocation),
                RequestPath = serverSetting.StaticFile.BaseRequestPath
            });
        }
    }
}