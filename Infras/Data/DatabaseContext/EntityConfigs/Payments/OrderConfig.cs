using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Payments;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Payments
{
    public class PaymentConfig : IEntityTypeConfiguration<Payment>,
        IBaseEntityIntPKConfig<Payment>,
        IGlobalCodeIdentiﬁableConfig<Payment>,
        IStoreCodeIdentiﬁableConfig<Payment>,
        IStatusableConfig<Payment>,
        ISoftDeletableConfig<Payment>,
        IAuditableConfig<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(TableNameConst.Payments);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.StoreCodeIdentiﬁableConfigure(builder, isRequired: false);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.Order)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.OrderId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.Amount)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.PaymentFee)
                    .HasColumnType(ColumnTypeConst.Decimal_19_2);
            builder.Property(t => t.FailureMessage)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000)
                    .IsRequired(false);
        }
    }
}