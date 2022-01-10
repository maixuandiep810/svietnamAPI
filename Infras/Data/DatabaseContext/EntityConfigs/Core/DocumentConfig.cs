using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DocumentConfig : IEntityTypeConfiguration<Document>, 
        IBaseEntityConfig<Document, int>,
        ICodeIdentiﬁableConfig<Document>,
        INameIdentiﬁableConfig<Document>,
        ISoftDeletableEntityConfig<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");
            this.BaseEntityConfigure(builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            this.SoftDeletableEntityConfigure(builder);
            builder.HasOne(p => p.DocumentType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(p => p.DocumentTypeId);
            builder.Property(t => t.Title)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.Location)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.Url)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.Desciption)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.DocumentTypeId)
                    .HasColumnType("Int");
        }
    }
}