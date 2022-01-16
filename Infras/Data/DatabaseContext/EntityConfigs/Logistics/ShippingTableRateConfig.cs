using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Logistics;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Logistics
{
    public class ShippingTableRateConfig : IEntityTypeConfiguration<ShippingTableRate>,
        IBaseEntityIntPKConfig<ShippingTableRate>,
        IGlobalCodeIdentiﬁableConfig<ShippingTableRate>,
        IStoreCodeIdentiﬁableConfig<ShippingTableRate>,
        IStatusableConfig<ShippingTableRate>,
        ISoftDeletableConfig<ShippingTableRate>,
        IAuditableConfig<ShippingTableRate>
    {
        public void Configure(EntityTypeBuilder<ShippingTableRate> builder)
        {
            builder.ToTable(TableNameConst.ShippingTableRates);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Store)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.StoreId);
            builder.HasOne(p => p.Commune)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.CommuneId);
            builder.HasOne(p => p.District)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.DistricId);
            builder.HasOne(p => p.Province)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ProvinceId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);


            builder.Property(t => t.MinOrderSubTotal)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.ShippingPrice)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.Description)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);
        }
    }
}