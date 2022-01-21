using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;

namespace svietnamAPI.Models.IRepositories
{
    public interface IGenericDbRepository<TEntity, TId>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>, new()
    {
        Task<List<TEntity>> GetBasicAllOrNullAsync();
        Task<TEntity> GetBasicByIdOrNullAsync(TId entityId);
        Task<TEntity> GetBasicByIdOrFailAsync(TId entityId);
        Task<TNameIdentifiable> GetBasicByUniqueNameOrNullAsync<TNameIdentifiable>(string enityUniqueName)
            where TNameIdentifiable : TEntity, INameIdentiﬁable, new();
        Task InsertAsync(TEntity entity);
        void Update<TUpdateDto>(TId entityId, TUpdateDto updateDto);
        void Update<TUpdateDto>(TId entityId, Action<TEntity> updateAction);
        void Delete(TId entityId);
        void SoftDelete<TSoftDeletable>(TId entityId)
        where TSoftDeletable : TEntity, ISoftDeletable, new();
        Task<List<TResult>> FindAsync<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> predicate, bool isAsNoTracking);
    }
}