using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;

namespace svietnamAPI.Models.IRepositories
{
    public interface IGenericDbRepository<TEntity, TId>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TId entityId);
        Task<TEntity> GetByIdIfNotNullAsync(TId entityId);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync<TUpdateDto>(TId entityId, TUpdateDto updateDto);
        Task UpdateAsync<TUpdateDto>(TId entityId, Action<TEntity> updateAction);
        Task DeleteAsync(TId entityId);
        Task<List<TResult>> FindAsync<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> predicate, bool isAsNoTracking);
        Task SoftDeleteAsync<TSoftDeletable>(TId entityId)
        where TSoftDeletable : TEntity, ISoftDeletable;
    }
}