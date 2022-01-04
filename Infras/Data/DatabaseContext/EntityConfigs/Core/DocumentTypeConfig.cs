using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>, IBaseEntityConfig<DocumentType, int>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("DocumentTypes");
            this.BaseEntityConfigure(builder);
            builder.Property(t => t.Name)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.Extension)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.MimeType)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
        }
    }
}