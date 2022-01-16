using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DocumentConfig : IEntityTypeConfiguration<Document>,
        IBaseEntityIntPKConfig<Document>,
        IGlobalCodeIdentiﬁableConfig<Document>,
        INameIdentiﬁableConfig<Document>,
        IStatusableConfig<Document>,
        ISoftDeletableConfig<Document>,
        IAuditableConfig<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable(TableNameConst.Documents);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 1000,
                maxLengthOfDisplayName: 1000,
                maxLengthOfSlug: 1000);
            this.StatusableConfigure(builder);
            this.SoftDeletableConfigure(builder);
            this.AuditableConfigure(builder);

            builder.HasOne(p => p.DocumentType)
                    .WithMany(p => p.Documents)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.DocumentTypeId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.Title)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
            builder.Property(t => t.Location)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
            builder.Property(t => t.Url)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
            builder.Property(t => t.Desciption)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);
        }
    }
}