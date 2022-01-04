using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using svietnamAPI.Controllers.Middlewares;
using svietnamAPI.StartupConfig.AppSettingConfig;

namespace svietnamAPI.StartupConfig.ApplicationBuilderConfig
{
    public static class UseDevEnvConfig
    {
        public static void DevEnvUseDeveloperExceptionPage(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
        public static void DevEnvUseSwagger(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "svietnamAPI v1"));
            }
        }
    }
}