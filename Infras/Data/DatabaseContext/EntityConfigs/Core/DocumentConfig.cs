using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class DocumentConfig : IEntityTypeConfiguration<Document>, 
        IBaseEntityConfig<Document, int>,
        ISoftDeletableEntityConfig<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");
            this.BaseEntityConfigure(builder);
            this.SoftDeletableEntityConfigure(builder);
            builder.HasOne(p => p.DocumentType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(p => p.DocumentTypeId);
            builder.Property(t => t.Name)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
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