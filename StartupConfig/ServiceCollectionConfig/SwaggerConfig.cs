using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;


namespace svietnamAPI.StartupConfig.ServiceCollectionConfig
{
    public static class SwaggerConfig
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "svietnamAPI", Version = "v1" });
            });
        }
    }
}