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
    public class GlobalProductCategoryDbRepository : GenericDbRepository<GlobalProductCategory, int>, 
        IGlobalProductCategoryDbRepository
    {
        public GlobalProductCategoryDbRepository(AppDbContext dbContext, 
            IValidator<GlobalProductCategory> validator, 
            IMapper mapper, 
            ILogger<GlobalProductCategoryDbRepository> logger) 
            : base(dbContext, validator, mapper, logger)
        {
        }

        public async Task SoftDeleteAsync(int entityId)
        {
            await SoftDeleteAsync<GlobalProductCategory>(entityId);
        }

        public async Task<List<GlobalProductCategory>> GetAllAsync(bool isIncludeImage)
        {
            try
            {
                if (isIncludeImage == false)
                {
                    var simpleCategories = await GetAllAsync();
                    return simpleCategories;
                }
                var categories_Image = await _dbContext.Set<GlobalProductCategory>().Select(p => p)
                    .AsNoTracking()
                    .Include(p => p.BaseImage)
                    .Include(p => p.ThumbnailImage)
                    .ToListAsync();
                return categories_Image;
            }
            catch (System.Exception systemEx)
            {
                throw new RepositoryAppException(systemEx);
            }
        }
    }
}