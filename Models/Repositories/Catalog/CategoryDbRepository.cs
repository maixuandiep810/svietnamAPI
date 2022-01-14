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
    public class CategoryDbRepository : GenericDbRepository<Category, int>, 
        ICategoryDbRepository
    {
        public CategoryDbRepository(AppDbContext dbContext, 
            IValidator<Category> validator, 
            IMapper mapper, 
            ILogger<CategoryDbRepository> logger) 
            : base(dbContext, validator, mapper, logger)
        {
        }

        public async Task SoftDeleteAsync(int entityId)
        {
            await SoftDeleteAsync<Category>(entityId);
        }

        public async Task<List<Category>> GetAllAsync(bool isIncludeImage)
        {
            try
            {
                if (isIncludeImage == false)
                {
                    var simpleCategories = await GetAllAsync();
                    return simpleCategories;
                }
                var categories_Image = await _dbContext.Set<Category>().Select(p => p)
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