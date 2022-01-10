using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class ProductItemConfig : IEntityTypeConfiguration<ProductItem>,
        IBaseEntityConfig<ProductItem, int>,
        ICodeIdentiﬁableConfig<ProductItem>,
        INameIdentiﬁableConfig<ProductItem>,
        ISoftDeletableEntityConfig<ProductItem>
    {
        public void Configure(EntityTypeBuilder<ProductItem> builder)
        {
            builder.ToTable("ProductItems");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder, 
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            this.SoftDeletableEntityConfigure(builder: builder);
            builder.HasOne(p => p.Product)
                    .WithMany(p => p.ProductItems)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.EntityStatusId);
        }
    }
}