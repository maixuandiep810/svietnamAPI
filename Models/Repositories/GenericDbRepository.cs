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
    where TEntity : class, IBaseEntity<TId>, new()
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

        public async Task<List<TEntity>> GetBasicAllOrNullAsync()
        {
            var entites = await FindAsync<TEntity>(p => p, p => true, isAsNoTracking: true);
            return entites;
        }

        public async Task<TEntity> GetBasicByIdOrNullAsync(TId entityId)
        {
            var entity = (await FindAsync<TEntity>(p => p, p => p.Id.Equals(entityId), isAsNoTracking: true))?.FirstOrDefault();
            return entity;
        }

        public async Task<TEntity> GetBasicByIdOrFailAsync(TId entityId)
        {
            var entity = await GetBasicByIdOrNullAsync(entityId);
            if (entity == null)
            {
                throw new NotFoundEntityAppException($"Entity Not Found: Id = {entityId}");
            }
            return entity;
        }

        public async Task<TNameIdentifiable> GetBasicByUniqueNameOrNullAsync<TNameIdentifiable>(string enityUniqueName)
            where TNameIdentifiable : TEntity, INameIdentiﬁable, new()
        {
            var entity = (TNameIdentifiable)(await FindAsync<TEntity>(p => p, p => ((INameIdentiﬁable)p).Name.Equals(enityUniqueName), isAsNoTracking: true))?.FirstOrDefault();
            return entity;
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public void Update<TUpdateDto>(TId entityId, TUpdateDto updateDto)
        {
            var entity = new TEntity { Id = entityId };
            _dbContext.Set<TEntity>().Attach(entity);
            entity = _mapper.Map<TUpdateDto, TEntity>(updateDto, entity);
        }

        public void Update<TUpdateDto>(TId entityId, Action<TEntity> updateAction)
        {
            var entity = new TEntity { Id = entityId };
            _dbContext.Set<TEntity>().Attach(entity);
            updateAction(entity);
        }

        public void Delete(TId entityId)
        {
            var entity = new TEntity { Id = entityId };
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void SoftDelete<TSoftDeletable>(TId entityId)
            where TSoftDeletable : TEntity, ISoftDeletable, new()
        {
            var entity = new TSoftDeletable
            {
                Id = entityId,
                IsDeleted = false
            };
            _dbContext.Set<TEntity>().Attach(entity);
            entity.IsDeleted = true;
        }

        public async Task<List<TResult>> FindAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> predicate,
            bool isAsNoTracking)
        {
            if (isAsNoTracking == true)
            {
                var entitiesNoTracking = await _dbContext.Set<TEntity>().Where(predicate).Select(selector).ToListAsync();
                return entitiesNoTracking;
            }
            var entitiesTracking = await _dbContext.Set<TEntity>().Where(predicate).Select(selector).ToListAsync();
            return entitiesTracking;
        }
    }
}