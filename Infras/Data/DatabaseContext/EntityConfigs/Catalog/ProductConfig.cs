using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class ProductConfig : IEntityTypeConfiguration<Product>,
        IBaseEntityIntPKConfig<Product>,
        IGlobalCodeIdentiﬁableConfig<Product>,
        IStoreCodeIdentiﬁableConfig<Product>,
        INameIdentiﬁableConfig<Product>,
        IStatusableConfig<Product>,
        ISoftDeletableConfig<Product>,
        IAuditableConfig<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(TableNameConst.Products);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 1000,
                maxLengthOfDisplayName: 1000,
                maxLengthOfSlug: 1000);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.LeafCategory)
                    .WithMany(p => p.Products)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.LeafCategoryId);
            builder.HasOne(p => p.Store)
                    .WithMany(p => p.Products)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.StoreId);
            builder.HasOne(p => p.CountryOfOrigin)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.CountryOfOriginId);
            builder.HasOne(p => p.Manufacturer)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ManufacturerId);
            builder.HasOne(p => p.Supplier)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.SupplierId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.SKU)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100)
                    .IsRequired(false);
            builder.Property(t => t.Description)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);
            builder.Property(t => t.ShortDescription)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
        }
    }
}