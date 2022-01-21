using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.IRepositories.Catalog
{
    public interface IGlobalProductCategoryDbRepository : IGenericDbRepository<GlobalProductCategory, int>
    {
        Task<List<GlobalProductCategorySummaryDto>> GetSummaryAllOrNullAsync();
        Task<GlobalProductCategorySummaryDto> GetSummaryByIdOrNullAsync(int gpcId);
        Task<List<GlobalProductCategory>> GetDetailAllOrNullAsync(bool shouldIncludeImage);
        Task<GlobalProductCategory> GetDetailByIdOrNullAsync(int gpcId, bool shouldIncludeImage);
        Task<List<GlobalProductCategorySummaryDto>> FindSummaryAllOrNullAsync(Expression<Func<GlobalProductCategory, bool>> predicate,
                    bool isAsNoTracking);
        Task<List<GlobalProductCategory>> FindDetailAllOrNullAsync(Expression<Func<GlobalProductCategory, bool>> predicate,
                    bool isAsNoTracking,
                    bool shouldIncludeImage);
    }
}