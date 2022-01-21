using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>,
        IBaseEntityIntPKConfig<DocumentType>,
        IGlobalCodeIdentiﬁableConfig<DocumentType>,
        INameIdentiﬁableConfig<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable(TableNameConst.DocumentTypeConsts);

            this.BaseEntityIntPKConfigure(builder: builder, 
                shouldUseIdentityColumn: false);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);

            builder.Property(t => t.Extension)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(100);
            builder.Property(t => t.MimeType)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(100);
        }
    }
}