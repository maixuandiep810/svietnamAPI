using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class INameIdentiﬁableConfigExtensions
    {
        public static void NameIdentiﬁableConfigure<TEntity>(this INameIdentiﬁableConfig<TEntity> entityConfig,
            EntityTypeBuilder<TEntity> builder,
            int maxLengthOfName = ColumnConstraintConst.Varchar_DefaultMaxLength,
            int maxLengthOfDisplayName = ColumnConstraintConst.Nvarchar_DefaultMaxLength,
            int maxLengthOfSlug = ColumnConstraintConst.Varchar_DefaultMaxLength)
            where TEntity : class, INameIdentiﬁable
        {
            builder.HasAlternateKey(p => p.Name);
            builder.HasAlternateKey(p => p.DisplayName);
            
            builder.Property(t => t.Name)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(maxLengthOfName)
                    .IsRequired();
            builder.Property(t => t.DisplayName)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(maxLengthOfDisplayName)
                    .IsRequired();
            builder.Property(t => t.Slug)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(maxLengthOfSlug);
        }
    }
}