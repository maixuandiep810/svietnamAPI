using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Infras.Mapper;
using svietnamAPI.Infras.Data.DatabaseContext;
using FluentValidation;
using svietnamAPI.StartupConfig.ServiceCollectionConfig.InfrasServices;

namespace svietnamAPI.StartupConfig.ServiceCollectionConfig
{
    public static class InfrasConfig
    {
        public static void AddInfras(this IServiceCollection services, IConfiguration configuration)
        {
            // Add AppDbContext
            services.AddAppDbContext(configuration);

            // Add AddAppStaticFileContext
            services.AddAppStaticFileContext(configuration);

            // Add AutoMapper
            services.AddAutoMapper();

            // Add CatalogValidator
            services.AddValidator();
        }
    }
}