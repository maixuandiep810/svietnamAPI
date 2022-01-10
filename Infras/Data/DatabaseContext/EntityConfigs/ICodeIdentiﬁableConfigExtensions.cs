using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class ICodeIdentiﬁableConfigExtensions
    {
        public static void CodeIdentiﬁableConfigure<TEntity>(this ICodeIdentiﬁableConfig<TEntity> entityConfig, 
            EntityTypeBuilder<TEntity> builder,
            int maxCodeLength = 3000)
            where TEntity : class, ICodeIdentiﬁable
        {
            builder.Property(t => t.Code)
                    .HasColumnType("Varchar")
                    .HasMaxLength(maxCodeLength)
                    .HasDefaultValue(false);
        }
    }
}