using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class INameIdentiﬁableConfigExtensions
    {
        public static void NameIdentiﬁableConfigure<TEntity>(this INameIdentiﬁableConfig<TEntity> entityConfig, 
            EntityTypeBuilder<TEntity> builder,
            int maxNameLength = 3000,
            int maxDisplayNameLength = 3000,
            int maxSlugLength = 3000)
            where TEntity : class, INameIdentiﬁable
        {
            builder.Property(t => t.Name)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(maxNameLength)
                    .HasDefaultValue(false);
            builder.Property(t => t.DisplayName)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(maxDisplayNameLength)
                    .HasDefaultValue(false);
            builder.Property(t => t.Slug)
                    .HasColumnType("Varchar")
                    .HasMaxLength(maxSlugLength)
                    .HasDefaultValue(false);
        }
    }
}