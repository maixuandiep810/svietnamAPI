using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Auth;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Auth
{
    public class AddressBookConfig : IEntityTypeConfiguration<AddressBook>,
        IBaseEntityIntPKConfig<AddressBook>,
        IGlobalCodeIdentiﬁableConfig<AddressBook>,
        ISoftDeletableConfig<AddressBook>
    {
        public void Configure(EntityTypeBuilder<AddressBook> builder)
        {
            builder.ToTable(TableNameConst.AddressBooks);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.SoftDeletableConfigure(builder);

            builder.HasOne(p => p.Address)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.AddressId);
            builder.HasOne(p => p.User)
                    .WithMany(p => p.AddressBooks)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.UserId);

            builder.Property(t => t.Email)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100);
            builder.Property(t => t.PhoneNumber)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(20);
        }
    }
}