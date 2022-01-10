using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class AddressConfig : IEntityTypeConfiguration<Address>, 
        IBaseEntityConfig<Address, int>,
        ICodeIdentiﬁableConfig<Address>,
        INameIdentiﬁableConfig<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.HasOne(t => t.Commune)
                        .WithMany()
                        .HasForeignKey(t => t.CommuneId);
            builder.Property(t => t.ContactName)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000)
                    .HasDefaultValue(false);
            builder.Property(t => t.PhoneNumber)
                    .HasColumnType("Varchar")
                    .HasMaxLength(3000)
                    .HasDefaultValue(false);
            builder.Property(t => t.AddressLine1)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000)
                    .HasDefaultValue(false);
            builder.Property(t => t.AddressLine2)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000)
                    .HasDefaultValue(false);
            builder.Property(t => t.ZipCode)
                    .HasColumnType("Varchar")
                    .HasMaxLength(3000)
                    .HasDefaultValue(false);
            builder.Property(t => t.CommuneId)
                    .HasColumnType("Int")
                    .HasDefaultValue(false);
        }
    }
}