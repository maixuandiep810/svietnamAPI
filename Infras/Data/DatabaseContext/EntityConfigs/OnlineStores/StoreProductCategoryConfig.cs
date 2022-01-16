using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineStores
{
    public class StoreProductCategoryConfig : IEntityTypeConfiguration<StoreProductCategory>,
        IBaseEntityIntPKConfig<StoreProductCategory>,
        IGlobalCodeIdentiﬁableConfig<StoreProductCategory>,
        IStoreCodeIdentiﬁableConfig<StoreProductCategory>,
        IStatusableConfig<StoreProductCategory>,
        ISoftDeletableConfig<StoreProductCategory>,
        IAuditableConfig<StoreProductCategory>
    {
        public void Configure(EntityTypeBuilder<StoreProductCategory> builder)
        {
            builder.ToTable(TableNameConst.StoreProductCategories);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Store)
                    .WithMany(p => p.StoreProductCategories)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.StoreId);
            builder.HasOne(p => p.GlobalProductCategory)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.GlobalProductCategoryId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);
        }
    }
}