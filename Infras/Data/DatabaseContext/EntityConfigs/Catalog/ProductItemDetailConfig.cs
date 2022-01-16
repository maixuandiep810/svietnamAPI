using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class ProductItemDetailConfig : IEntityTypeConfiguration<ProductItemDetail>,
        IBaseEntityIntPKConfig<ProductItemDetail>,
        IGlobalCodeIdentiﬁableConfig<ProductItemDetail>,
        IStoreCodeIdentiﬁableConfig<ProductItemDetail>,
        IStatusableConfig<ProductItemDetail>,
        ISoftDeletableConfig<ProductItemDetail>,
        IAuditableConfig<ProductItemDetail>
    {
        public void Configure(EntityTypeBuilder<ProductItemDetail> builder)
        {
            builder.ToTable(TableNameConst.ProductItemDetails);

            this.BaseEntityIntPKConfigure(builder);
            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.ProductItem)
                    .WithMany(p => p.ProductItemDetails)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.ProductItemId);
            builder.HasOne(p => p.EavAttributeValue)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EavAttributeValueId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);
        }
    }
}