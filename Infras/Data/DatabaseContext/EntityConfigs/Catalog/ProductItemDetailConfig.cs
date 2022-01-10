using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class ProductItemDetailConfig : IEntityTypeConfiguration<ProductItemDetail>,
        IBaseEntityConfig<ProductItemDetail, int>
    {
        public void Configure(EntityTypeBuilder<ProductItemDetail> builder)
        {
            builder.ToTable("ProductItemDetails");
            this.BaseEntityConfigure(builder: builder);
            builder.HasOne(p => p.ProductItem)
                    .WithMany(p => p.ProductItemDetails)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.ProductItemId);
            builder.HasOne(p => p.EavAttributeValue)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.EavAttributeValueId);
        }
    }
}