using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Infras.Mapper;
using svietnamAPI.Infras.Data.DatabaseContext;
using FluentValidation;
using svietnamAPI.Infras.Data.StaticFileContext;

namespace svietnamAPI.StartupConfig.ServiceCollectionConfig.InfrasServices
{
    public static class AppStaticFileContextConfig
    {
        public static void AddAppStaticFileContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Add AppStaticFileContext
            services.AddScoped<AppStaticFileContext, AppStaticFileContext>();
        }
    }
}