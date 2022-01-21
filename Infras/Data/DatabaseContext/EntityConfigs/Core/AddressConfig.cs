using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class AddressConfig : IEntityTypeConfiguration<Address>, 
        IBaseEntityIntPKConfig<Address>,
        IGlobalCodeIdentiﬁableConfig<Address>,
        INameIdentiﬁableConfig<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(TableNameConst.Addresses);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);

            builder.HasOne(t => t.Commune)
                        .WithMany()
                        .HasForeignKey(t => t.CommuneId)
                        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.District)
                        .WithMany()
                        .HasForeignKey(t => t.DistrictId)
                        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Province)
                        .WithMany()
                        .HasForeignKey(t => t.ProvinceId)
                        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Country)
                        .WithMany()
                        .HasForeignKey(t => t.CountryId)
                        .OnDelete(DeleteBehavior.Restrict);
                        

            builder.Property(t => t.ContactName)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
            builder.Property(t => t.PhoneNumber)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100);
            builder.Property(t => t.AddressLine1)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
            builder.Property(t => t.AddressLine2)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
            builder.Property(t => t.ZipCode)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100)
                    .HasDefaultValue(false);
        }
    }
}