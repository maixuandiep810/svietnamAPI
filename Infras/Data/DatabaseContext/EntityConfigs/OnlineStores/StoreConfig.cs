using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.OnlineStores
{
    public class StoreConfig : IEntityTypeConfiguration<Store>,
        IBaseEntityIntPKConfig<Store>,
        IGlobalCodeIdentiﬁableConfig<Store>,
        IStoreCodeIdentiﬁableConfig<Store>,
        INameIdentiﬁableConfig<Store>,
        IStatusableConfig<Store>,
        ISoftDeletableConfig<Store>,
        IAuditableConfig<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable(TableNameConst.Stores);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 1000,
                maxLengthOfDisplayName: 1000,
                maxLengthOfSlug: 1000);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Address)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.AddressId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.Email)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100);
            builder.Property(t => t.PhoneNumber)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(20);
        }
    }
}