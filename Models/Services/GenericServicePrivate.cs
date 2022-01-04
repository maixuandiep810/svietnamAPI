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
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.IUnitOfWorks;

namespace svietnamAPI.Models.Services
{
    public abstract partial class GenericService<TEntity, TId, TDbRepo> : IGenericService<TEntity, TId>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>
    where TDbRepo : IGenericDbRepository<TEntity, TId>
    {
    }
}