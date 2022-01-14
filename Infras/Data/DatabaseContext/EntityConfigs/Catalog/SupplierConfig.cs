using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class SupplierConfig : IEntityTypeConfiguration<Supplier>,
        IBaseEntityIntPKConfig<Supplier>,
        IGlobalCodeIdentiﬁableConfig<Supplier>,
        INameIdentiﬁableConfig<Supplier>,
        IStatusableConfig<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable(TableNameConst.Suppliers);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
            this.StatusableConfigure(builder: builder);

            builder.HasOne(p => p.Address)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.AddressId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.EntityStatusId);
        }
    }
}