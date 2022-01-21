using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Infras.Data.DatabaseContext;
using System.Linq;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Models.IRepositories.Core;

namespace svietnamAPI.Models.Repositories.Core
{
    public class EntityStatusDbRepository : GenericDbRepository<EntityStatus, int>, IEntityStatusDbRepository
    {
        public EntityStatusDbRepository(AppDbContext dbContext, IValidator<EntityStatus> validator, IMapper mapper, ILogger<IEntityStatusDbRepository> logger) : base(dbContext, validator, mapper, logger)
        {
        }
    }
}