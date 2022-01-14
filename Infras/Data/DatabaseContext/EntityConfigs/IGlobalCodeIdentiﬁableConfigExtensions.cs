using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IGlobalCodeIdentiﬁableConfigExtensions
    {
        public static void GlobalCodeIdentiﬁableConfigure<TEntity>(this IGlobalCodeIdentiﬁableConfig<TEntity> entityConfig,
            EntityTypeBuilder<TEntity> builder)
            where TEntity : class, IGlobalCodeIdentiﬁable
        {
            builder.HasAlternateKey(p => p.GlobalCode);
            
            builder.Property(t => t.GlobalCode)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(12);
        }
    }
}