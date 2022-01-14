using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class ISoftDeletableConfigExtensions
    {
        public static void SoftDeletableConfigure<TEntity>(this ISoftDeletableConfig<TEntity> entityConfig, 
            EntityTypeBuilder<TEntity> builder)
            where TEntity : class, ISoftDeletable
        {
        }
    }
}