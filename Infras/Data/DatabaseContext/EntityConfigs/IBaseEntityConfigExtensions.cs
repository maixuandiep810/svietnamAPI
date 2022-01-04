using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IBaseEntityConfigExtensions
    {
        public static void BaseEntityConfigure<TEntity, TId>(this IBaseEntityConfig<TEntity, TId> entityConfig, EntityTypeBuilder<TEntity> builder)
        where TId : struct
        where TEntity : class, IBaseEntity<TId>
        {
            builder.HasKey(o => o.Id);
        }
    }
}