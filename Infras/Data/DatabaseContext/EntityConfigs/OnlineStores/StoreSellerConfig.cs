using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineStores
{
    public class StoreSellerConfig : IEntityTypeConfiguration<StoreSeller>,
        IBaseEntityIntPKConfig<StoreSeller>,
        IGlobalCodeIdentiﬁableConfig<StoreSeller>,
        IStoreCodeIdentiﬁableConfig<StoreSeller>,
        INameIdentiﬁableConfig<StoreSeller>,
        IStatusableConfig<StoreSeller>,
        ISoftDeletableConfig<StoreSeller>,
        IAuditableConfig<StoreSeller>
    {
        public void Configure(EntityTypeBuilder<StoreSeller> builder)
        {
            builder.ToTable(TableNameConst.StoreSellers);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Store)
                    .WithMany(p => p.StoreSellers)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.StoreId);
            builder.HasOne(p => p.User)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);
        }
    }
}