using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>,
        IBaseEntityConfig<DocumentType, int>,
        ICodeIdentiﬁableConfig<DocumentType>,
        INameIdentiﬁableConfig<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("DocumentTypes");
            this.BaseEntityConfigure(builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.Property(t => t.Extension)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.MimeType)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
        }
    }
}