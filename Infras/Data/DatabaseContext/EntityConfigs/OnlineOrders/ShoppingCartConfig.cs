using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineOrders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineOrders
{
    public class ShoppingCartConfig : IEntityTypeConfiguration<ShoppingCart>,
        IBaseEntityIntPKConfig<ShoppingCart>,
        IGlobalCodeIdentiﬁableConfig<ShoppingCart>,
        IStatusableConfig<ShoppingCart>,
        ISoftDeletableConfig<ShoppingCart>,
        IAuditableConfig<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.ToTable(TableNameConst.ShoppingCarts);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
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
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.ShoppingCartNote)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000)
                    .IsRequired(false);
        }
    }
}