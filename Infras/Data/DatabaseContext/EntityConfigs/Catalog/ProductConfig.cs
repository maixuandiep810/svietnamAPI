using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class ProductConfig : IEntityTypeConfiguration<Product>,
        IBaseEntityConfig<Product, int>,
        ICodeIdentiﬁableConfig<Product>,
        INameIdentiﬁableConfig<Product>,
        ISoftDeletableEntityConfig<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder, 
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            this.SoftDeletableEntityConfigure(builder: builder);
            builder.HasOne(p => p.LeafCategory)
                    .WithMany(p => p.Products)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.LeafCategoryId);
                //     .HasConstraintName("FK_Products_Categories_LeafCategoryId");
            builder.HasOne(p => p.Manufacturer)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.ManufacturerId);
            builder.HasOne(p => p.Supplier)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.SupplierId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.EntityStatusId);
            builder.Property(t => t.SKU)
                    .HasColumnType("Varchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.Description)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.ShortDescription)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.ItemsCount)
                    .HasColumnType("Int");
        }
    }
}