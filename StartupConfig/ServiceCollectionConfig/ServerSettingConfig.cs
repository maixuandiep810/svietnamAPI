using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.StartupConfig.AppSettingConfig;

namespace svietnamAPI.StartupConfig.ServiceCollectionConfig
{
    public static class ServerSettingConfig
    {
        public static void AddServerSetting(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServerSetting>(configuration.GetSection("ServerSetting"));
        }
    }
}