using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using svietnamAPI.Infras.Mapper;
using svietnamAPI.Infras.Data.DatabaseContext;
using FluentValidation;
// using svietnamAPI.Infras.Validation.Entities.Catalog;
// using svietnamAPI.Infras.Validation.Dtos.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.Catalog;


namespace svietnamAPI.StartupConfig.ServiceCollectionConfig.InfrasServices
{
    public static class ValidatorConfig
    {
        public static void AddValidator(this IServiceCollection services)
        {
            // Add CatalogValidator
            // services.AddScoped<IValidator<Category>, CategoryValidator>();
            // services.AddScoped<IValidator<CreateCategoryDto>, CreateCategoryDtoValidator>();
        }
    }
}