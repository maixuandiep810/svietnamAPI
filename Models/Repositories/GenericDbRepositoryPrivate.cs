using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.Models.IRepositories;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Common.Exceptions.Repositories;
using System.Linq;

namespace svietnamAPI.Models.Repositories
{
    public abstract partial class GenericDbRepository<TEntity, TId> : IGenericDbRepository<TEntity, TId>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>
    {
        private async Task<TSoftDeletable> GetISoftDeletableByIdIfNotNullAsync<TSoftDeletable>(TId entityId)
        where TSoftDeletable : TEntity, ISoftDeletable
        {
            try
            {
                var entity = (TSoftDeletable)(await FindAsync<TEntity>(p => p, p => p.Id.Equals(entityId)))?.FirstOrDefault();
                if (entity == null)
                {
                    throw new NotFoundEntityAppException($"Entity Not Found: Id = {entityId}");
                }
                return entity;
            }
            catch (System.Exception systemEx)
            {
                _logger.LogDebug(systemEx, "");
                _logger.LogInformation(systemEx, "");
                throw new RepositoryAppException(systemEx);
            }
        }
    }
}