using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IAuditableEntityConfigExtensions
    {
        public static void AuditableEntityConfigure<TEntity>(this IAuditableEntityConfig<TEntity> entityConfig, 
            EntityTypeBuilder<TEntity> builder)
            where TEntity : class, IAuditable
        {
            builder.Property(t => t.CreatedAt)
                    .HasColumnType("Datetime")
                    .IsRequired(false);
            builder.Property(t => t.CreatedBy)
                    .HasColumnType("Int")
                    .IsRequired(false);
            builder.Property(t => t.UpdatedAt)
                    .HasColumnType("Datetime")
                    .IsRequired(false);
            builder.Property(t => t.UpdatedBy)
                    .HasColumnType("Int")
                    .IsRequired(false);
        }
    }
}