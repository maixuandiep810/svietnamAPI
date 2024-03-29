using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class ProductItemConfig : IEntityTypeConfiguration<ProductItem>,
        IBaseEntityIntPKConfig<ProductItem>,
        IGlobalCodeIdentiﬁableConfig<ProductItem>,
        INameIdentiﬁableConfig<ProductItem>,
        IStoreCodeIdentiﬁableConfig<ProductItem>,
        IStatusableConfig<ProductItem>,
        ISoftDeletableConfig<ProductItem>,
        IAuditableConfig<ProductItem>
    {
        public void Configure(EntityTypeBuilder<ProductItem> builder)
        {
            builder.ToTable(TableNameConst.ProductItems);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 1000,
                maxLengthOfDisplayName: 1000,
                maxLengthOfSlug: 1000);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Product)
                    .WithMany(p => p.ProductItems)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.SKU)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100);
            builder.Property(t => t.Description)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);
            builder.Property(t => t.ProductItemPrice)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
        }
    }
}