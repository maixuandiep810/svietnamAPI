using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public interface IBaseEntityConfig<TEntity, TId>
        where TId : struct
        where TEntity : class, IBaseEntity<TId>
    {
    }
}