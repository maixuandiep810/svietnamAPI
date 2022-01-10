using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class SupplierConfig : IEntityTypeConfiguration<Supplier>,
        IBaseEntityConfig<Supplier, int>,
        ICodeIdentiﬁableConfig<Supplier>,
        INameIdentiﬁableConfig<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.HasOne(p => p.Address)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.AddressId);
            builder.Property(t => t.AddressId)
                    .HasColumnType("Int");
        }
    }
}