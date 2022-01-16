using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Auth;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Auth
{
    public class UserConfig : IEntityTypeConfiguration<User>,
        IBaseEntityIntPKConfig<User>,
        IGlobalCodeIdentiﬁableConfig<User>,
        INameIdentiﬁableConfig<User>,
        IStatusableConfig<User>,
        ISoftDeletableConfig<User>,
        IAuditableConfig<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(TableNameConst.Users);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

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
            builder.Property(t => t.Salt)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100);
            builder.Property(t => t.HashedPassword)
                    .HasColumnType(ColumnTypeConst.Varchar)
                    .HasMaxLength(100);
            builder.Property(t => t.BirthDay)
                    .HasColumnType(ColumnTypeConst.Date);
        }
    }
}