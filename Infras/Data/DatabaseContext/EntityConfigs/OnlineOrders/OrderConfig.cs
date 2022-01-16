using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineOrders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineOrders
{
    public class OrderConfig : IEntityTypeConfiguration<Order>,
        IBaseEntityIntPKConfig<Order>,
        IGlobalCodeIdentiﬁableConfig<Order>,
        IStoreCodeIdentiﬁableConfig<Order>,
        IStatusableConfig<Order>,
        ISoftDeletableConfig<Order>,
        IAuditableConfig<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(TableNameConst.Orders);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Parent)
                    .WithMany(p => p.Children)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ParentId);
            builder.HasOne(p => p.Buyer)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);
            builder.HasOne(p => p.Store)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.StoreId);
            builder.HasOne(p => p.ShippingAddress)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ShippingAddressId);
            builder.HasOne(p => p.BillingAddress)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.BillingAddressingId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.SubTotal)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.ShippingPrice)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.OrderTotal)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.OrderNote)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000)
                    .IsRequired(false);
        }
    }
}