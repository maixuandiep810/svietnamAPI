using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public interface IBaseEntityIntPKConfig<TEntity>
        where TEntity : class, IBaseEntity<int>
    {
    }
}