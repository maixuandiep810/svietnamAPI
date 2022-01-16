using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineOrders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineOrders
{
    public class ShoppingCartItemConfig : IEntityTypeConfiguration<ShoppingCartItem>,
        IBaseEntityIntPKConfig<ShoppingCartItem>,
        IGlobalCodeIdentiﬁableConfig<ShoppingCartItem>,
        IStatusableConfig<ShoppingCartItem>,
        ISoftDeletableConfig<ShoppingCartItem>,
        IAuditableConfig<ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            builder.ToTable(TableNameConst.ShoppingCartItems);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.ShoppingCart)
                    .WithMany(p => p.ShoppingCartItems)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ShoppingCartId);
            builder.HasOne(p => p.ProductItem)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ProductItemId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.ShoppingCartItemNote)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000)
                    .IsRequired(false);
        }
    }
}