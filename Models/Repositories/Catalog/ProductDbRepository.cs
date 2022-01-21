using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Common.Exceptions.Repositories;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Models.IRepositories.Catalog;
using System.Linq;
using svietnamAPI.Common.Dtos.Values.EntityValidationMessage.Catalog;
using FluentValidation;
using Microsoft.EntityFrameworkCore;


namespace svietnamAPI.Models.Repositories.Catalog
{
    public class ProductDbRepository : GenericDbRepository<Product, int>, IProductDbRepository
    {
        public ProductDbRepository(AppDbContext dbContext, IValidator<Product> validator, IMapper mapper, ILogger<ProductDbRepository> logger) : base(dbContext, validator, mapper, logger)
        {
        }

        public async Task<List<Product>> GetFullAllOrNullAsync(bool shouldIncludeProductItem)
        {
            var productsQueryable = _dbContext.Set<Product>()
                .Select(p => p)
                .AsNoTracking();
            if (shouldIncludeProductItem == true)
            {
                productsQueryable = productsQueryable.Include(p => p.ProductItems)
                    .ThenInclude(p => p.ProductItemDetails)
                    .ThenInclude(p => p.EavAttributeValue);
            }
            var productEntities = await productsQueryable.ToListAsync();
            return productEntities;

        }
    }
}