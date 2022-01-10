using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace svietnamAPI.StartupConfig.ServiceCollectionConfig
{
    public static class ControllerConfig
    {
        public static void AddControllers(this IServiceCollection services, IConfiguration configuration)
        {
            // services.AddControllers();
            services.AddControllers().AddNewtonsoftJson((x) =>
            {
                x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
        }
    }
}