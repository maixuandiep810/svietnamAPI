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
using FluentValidation;

namespace svietnamAPI.Models.Repositories
{
    public abstract partial class GenericDbRepository<TEntity, TId> : IGenericDbRepository<TEntity, TId>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>
    {
        protected readonly AppDbContext _dbContext;
        protected readonly IValidator<TEntity> _validator;
        protected readonly IMapper _mapper;
        protected readonly ILogger _logger;

        public GenericDbRepository(AppDbContext dbContext, IValidator<TEntity> validator, IMapper mapper, ILogger logger)
        {
            _dbContext = dbContext;
            _validator = validator;
            _mapper = mapper;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var entites = await FindAsync<TEntity>(p => p, p => true);
            return entites;
        }

        public async Task<TEntity> GetByIdAsync(TId entityId)
        {
            var entity = (await FindAsync<TEntity>(p => p, p => p.Id.Equals(entityId)))?.FirstOrDefault();
            return entity;
        }

        public async Task<TEntity> GetByIdIfNotNullAsync(TId entityId)
        {
            var entity = await GetByIdAsync(entityId);
            if (entity == null)
            {
                throw new NotFoundEntityAppException($"Entity Not Found: Id = {entityId}");
            }
            return entity;
        }

        public async Task InsertAsync(TEntity entity)
        {
            try
            {
                await _dbContext.Set<TEntity>().AddAsync(entity);
            }
            catch (EntityValidationFailedAppException entityValidationFailedAppEx)
            {
                throw entityValidationFailedAppEx;
            }
            catch (System.Exception systemEx)
            {
                _logger.LogDebug(systemEx, "");
                _logger.LogInformation(systemEx, "");
                throw new RepositoryAppException(systemEx);
            }
        }

        public async Task UpdateAsync<TUpdateDto>(TId entityId, TUpdateDto updateDto)
        {
            try
            {
                var entity = await GetByIdIfNotNullAsync(entityId);
                entity = _mapper.Map<TUpdateDto, TEntity>(updateDto, entity);
            }
            catch (NotFoundEntityAppException notFoundEntityAppEx)
            {
                throw notFoundEntityAppEx;
            }
            catch (EntityValidationFailedAppException entityValidationFailedAppEx)
            {
                throw entityValidationFailedAppEx;
            }
            catch (System.Exception systemEx)
            {
                _logger.LogDebug(systemEx, "");
                _logger.LogInformation(systemEx, "");
                throw new RepositoryAppException(systemEx);
            }
        }

        public async Task UpdateAsync<TUpdateDto>(TId entityId, Action<TEntity> updateAction)
        {
            try
            {
                var entity = await GetByIdIfNotNullAsync(entityId);
                updateAction(entity);
            }
            catch (EntityValidationFailedAppException entityValidationFailedAppEx)
            {
                throw entityValidationFailedAppEx;
            }
            catch (System.Exception systemEx)
            {
                _logger.LogDebug(systemEx, "");
                _logger.LogInformation(systemEx, "");
                throw new RepositoryAppException(systemEx);
            }
        }

        public async Task DeleteAsync(TId entityId)
        {
            try
            {
                var entity = await GetByIdIfNotNullAsync(entityId);
                _dbContext.Set<TEntity>().Remove(entity);
            }
            catch (System.Exception systemEx)
            {
                _logger.LogDebug(systemEx, "");
                _logger.LogInformation(systemEx, "");
                throw new RepositoryAppException(systemEx);
            }
        }

        public async Task<List<TResult>> FindAsync<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                var entities = await _dbContext.Set<TEntity>().Where(predicate).Select(selector).ToListAsync();
                return entities;
            }
            catch (System.Exception systemEx)
            {
                throw new RepositoryAppException(systemEx);
            }
        }

        public async Task SoftDeleteAsync<TSoftDeletable>(TId entityId)
        where TSoftDeletable : TEntity, ISoftDeletable
        {
            try
            {
                // var entity = await GetISoftDeletableByIdIfNotNullAsync<TSoftDeletable>(entityId);
                var entity = (ISoftDeletable)(await GetByIdIfNotNullAsync(entityId));
                entity.IsDeleted = true;
            }
            catch (System.Exception systemEx)
            {
                throw new RepositoryAppException(systemEx);
            }
        }
    }
}