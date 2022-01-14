using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeValueConfig : IEntityTypeConfiguration<EavAttributeValue>,
        IBaseEntityIntPKConfig<EavAttributeValue>,
        IGlobalCodeIdentiﬁableConfig<EavAttributeValue>,
        IStatusableConfig<EavAttributeValue>,
        ISoftDeletableConfig<EavAttributeValue>,
        IAuditableConfig<EavAttributeValue>        
    {
        public void Configure(EntityTypeBuilder<EavAttributeValue> builder)
        {
            builder.ToTable(TableNameConst.EavAttributeValues);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.StatusableConfigure(builder: builder);
            this.SoftDeletableConfigure(builder: builder);
            this.AuditableConfigure(builder: builder);

            builder.Property(t => t.ValueToString)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);

        }
    }
}