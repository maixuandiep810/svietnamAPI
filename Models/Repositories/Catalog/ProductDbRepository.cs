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

        public async Task SoftDeleteAsync(int entityId)
        {
            await SoftDeleteAsync<Product>(entityId);
        }

        public async Task<List<Product>> GetAllAsync(bool isIncludeProductItem,
            bool isIncludeProductItemDetail,
            bool isIncludeEavValue)
        {
            try
            {
                if (isIncludeProductItem == false)
                {
                    var simpleProducts = await GetAllAsync();
                    return simpleProducts;
                }
                if (isIncludeProductItemDetail == false)
                {
                    var products_PItem = await _dbContext.Set<Product>()
                        .AsNoTracking()
                        .Select(p => p)
                        .Include(p => p.ProductItems)
                        .ToListAsync();
                    return products_PItem;
                }
                if (isIncludeEavValue == false)
                {
                    var products_PItem_PItemDetail = await _dbContext.Set<Product>()
                        .AsNoTracking()
                        .Select(p => p)
                        .Include(p => p.ProductItems)
                        .ThenInclude(p => p.ProductItemDetails)
                        .ToListAsync();
                    return products_PItem_PItemDetail;
                }
                var products_PItem_PItemDetail_EavValue = await _dbContext.Set<Product>()
                    .AsNoTracking()
                    .Select(p => p)
                    .Include(p => p.ProductItems)
                    .ThenInclude(p => p.ProductItemDetails)
                    .ThenInclude(p => p.EavAttributeValue)
                    .ToListAsync();
                return products_PItem_PItemDetail_EavValue;
            }
            catch (System.Exception systemEx)
            {
                throw new RepositoryAppException(systemEx);
            }
        }
    }
}