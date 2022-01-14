using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class GlobalProductCategoryConfig : IEntityTypeConfiguration<GlobalProductCategory>,
        IBaseEntityIntPKConfig<GlobalProductCategory>,
        IGlobalCodeIdentiﬁableConfig<GlobalProductCategory>,
        INameIdentiﬁableConfig<GlobalProductCategory>,
        IStatusableConfig<GlobalProductCategory>,
        ISoftDeletableConfig<GlobalProductCategory>,
        IAuditableConfig<GlobalProductCategory>
    {
        public void Configure(EntityTypeBuilder<GlobalProductCategory> builder)
        {
            builder.ToTable(TableNameConst.GlobalProductCategories);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
            this.StatusableConfigure(builder: builder);
            this.SoftDeletableConfigure(builder: builder);
            this.AuditableConfigure(builder: builder);

            builder.HasOne(p => p.Parent)
                    .WithMany(p => p.Children)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasForeignKey(p => p.ParentId);
            builder.HasOne(p => p.BaseImage)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.BaseImageId);
            builder.HasOne(p => p.ThumbnailImage)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.ThumbnailImageId);
            builder.HasOne(p => p.EntityStatus)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.EntityStatusId);

            builder.Property(t => t.Description)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(3000);
            builder.Property(t => t.ShortDescription)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(1000);
        }
    }
}