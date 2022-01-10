using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Models.Services;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.UnitOfWorks;
using svietnamAPI.Models.IUnitOfWorks;
using Microsoft.Extensions.Configuration;

namespace svietnamAPI.StartupConfig.ServiceCollectionConfig
{
    public static class ModelsConfig
    {
        public static void AddModels(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
        }
    }
}