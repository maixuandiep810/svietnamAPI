using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IStoreCodeIdentiﬁableConfigExtensions
    {
        public static void StoreCodeIdentiﬁableConfigure<TEntity>(this IStoreCodeIdentiﬁableConfig<TEntity> entityConfig,
            EntityTypeBuilder<TEntity> builder,
            bool isRequired = true)
            where TEntity : class, IStoreCodeIdentiﬁable
        {
            builder.Property(t => t.StoreCode)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100)
                    .IsRequired(isRequired);
        }
    }
}