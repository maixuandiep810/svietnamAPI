using System.Collections.Generic;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Models.IRepositories.Core
{
    public interface IEntityStatusDbRepository : IGenericDbRepository<EntityStatus, int>
    {
    }
}