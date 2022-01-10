using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class ISoftDeletableEntityConfigExtensions
    {
        public static void SoftDeletableEntityConfigure<TEntity>(this ISoftDeletableEntityConfig<TEntity> entityConfig, 
            EntityTypeBuilder<TEntity> builder)
            where TEntity : class, ISoftDeletable
        {
            builder.Property(t => t.IsDeleted)
                    .HasColumnType("Bit")
                    .HasDefaultValue(false);
        }
    }
}