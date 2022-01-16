using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineOrders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineOrders
{
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>,
        IBaseEntityIntPKConfig<OrderItem>,
        IGlobalCodeIdentiﬁableConfig<OrderItem>,
        IStoreCodeIdentiﬁableConfig<OrderItem>,
        IStatusableConfig<OrderItem>,
        ISoftDeletableConfig<OrderItem>,
        IAuditableConfig<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(TableNameConst.OrderItems);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Order)
                    .WithMany(p => p.OrderItems)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.OrderId);
            builder.HasOne(p => p.ProductItem)
                    .WithMany(p => p.OrderItems)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ProductItemId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.ProductItemPrice)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.OrderItemNote)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000)
                    .IsRequired(false);
        }
    }
}