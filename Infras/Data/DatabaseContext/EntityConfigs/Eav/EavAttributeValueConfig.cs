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

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.EavAttribute)
                    .WithMany(p => p.EavAttributeValues)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EavAttributeId);

            builder.Property(t => t.ValueToString)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);

        }
    }
}