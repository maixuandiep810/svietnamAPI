using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Infras.Mapper;
using svietnamAPI.Infras.Data.DatabaseContext;
using FluentValidation;

namespace svietnamAPI.StartupConfig.ServiceCollectionConfig.InfrasServices
{
    public static class AppDbContextConfig
    {
        public static void AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Add DbContext
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetValue<string>("ServerSetting:Database:AppDbContextConnection"));
            });
        }
    }
}