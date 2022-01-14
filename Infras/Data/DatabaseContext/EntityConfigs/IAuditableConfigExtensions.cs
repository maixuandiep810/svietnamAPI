using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IAuditableConfigExtensions
    {
        public static void AuditableConfigure<TEntity>(this IAuditableConfig<TEntity> entityConfig,
            EntityTypeBuilder<TEntity> builder)
            where TEntity : class, IAuditable
        {
            builder.Property(t => t.CreatedAt)
                    .HasColumnType(ColumnTypeConst.Datetime);
            builder.Property(t => t.UpdatedAt)
                    .HasColumnType(ColumnTypeConst.Datetime);
        }
    }
}