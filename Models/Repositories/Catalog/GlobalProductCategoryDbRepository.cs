using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Models.IRepositories.Catalog;
using System.Linq;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;
using System.Linq.Expressions;
using System;

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

        public async Task<List<GlobalProductCategorySummaryDto>> GetSummaryAllOrNullAsync()
        {
            var globalPCSummaryDtos = await FindSummaryAllOrNullAsync(p => true, true);
            return globalPCSummaryDtos;
        }

        public async Task<GlobalProductCategorySummaryDto> GetSummaryByIdOrNullAsync(int gpcId)
        {
            var globalPCSummaryDto = (await FindSummaryAllOrNullAsync(p => p.Id == gpcId, true))?.First();
            return globalPCSummaryDto;
        }

        public async Task<List<GlobalProductCategory>> GetDetailAllOrNullAsync(bool shouldIncludeImage)
        {
            var globalPCEntities = await FindDetailAllOrNullAsync(p => true, true, true);
            return globalPCEntities;
        }

        public async Task<GlobalProductCategory> GetDetailByIdOrNullAsync(int gpcId, bool shouldIncludeImage)
        {
            var globalPCEntity = (await FindDetailAllOrNullAsync(p => p.Id == gpcId, true, true))?.First();
            return globalPCEntity;
        }

        public async Task<List<GlobalProductCategorySummaryDto>> FindSummaryAllOrNullAsync(Expression<Func<GlobalProductCategory, bool>> predicate,
            bool isAsNoTracking)
        {
            var globalPCSummaryDtoQueryable = _dbContext.Set<GlobalProductCategory>()
                .Where(predicate)
                .Select(
                    p => _mapper.Map<GlobalProductCategory, GlobalProductCategorySummaryDto>(p)
                );
            //
            if (isAsNoTracking)
            {
                globalPCSummaryDtoQueryable = globalPCSummaryDtoQueryable.AsNoTracking();
            }
            //
            var globalPCSummaryDtos = await globalPCSummaryDtoQueryable.ToListAsync();
            return globalPCSummaryDtos;
        }

        public async Task<List<GlobalProductCategory>> FindDetailAllOrNullAsync(Expression<Func<GlobalProductCategory, bool>> predicate,
            bool isAsNoTracking,
            bool shouldIncludeImage)
        {
            //
            IQueryable<GlobalProductCategory> globalPCsQueryable = _dbContext.Set<GlobalProductCategory>()
                .Where(predicate)
                .Select(p => p);
            if (isAsNoTracking)
            {
                globalPCsQueryable = globalPCsQueryable.AsNoTracking();
            }
            //
            if (shouldIncludeImage)
            {
                globalPCsQueryable = globalPCsQueryable.Include(p => p.BaseImage)
                    .Include(p => p.ThumbnailImage);
            }
            //
            var globalPCEntities = await globalPCsQueryable.ToListAsync();
            return globalPCEntities;
        }
    }
}