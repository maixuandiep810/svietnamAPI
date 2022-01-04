using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>,
        IBaseEntityConfig<Category, int>,
        ISoftDeletableEntityConfig<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            this.BaseEntityConfigure(builder);
            this.SoftDeletableEntityConfigure(builder);
            builder.HasOne(p => p.BaseImage)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.BaseImageId);
            builder.HasOne(p => p.ThumbnailImage)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(p => p.ThumbnailImageId);
            builder.Property(t => t.Name)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.Slug)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.IsRoot)
                    .HasColumnType("Bit");
            builder.Property(t => t.ParentId)
                    .HasColumnType("Int");
            builder.Property(t => t.ChildrenCount)
                    .HasColumnType("Int");
            builder.Property(t => t.ProductCount)
                    .HasColumnType("Int");
            builder.Property(t => t.Description)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.ShortDescription)
                    .HasColumnType("Nvarchar")
                    .HasMaxLength(3000);
            builder.Property(t => t.ThumbnailImageId)
                    .HasColumnType("Int");
            builder.Property(t => t.IsEnabled)
                    .HasColumnType("Bit");
            builder.Property(t => t.IsDeleted)
                    .HasColumnType("Bit");
            builder.Property(t => t.CreatedAt)
                    .HasColumnType("Datetime");
            builder.Property(t => t.CreatedBy)
                    .HasColumnType("Int");
            builder.Property(t => t.CreatedAt)
                    .HasColumnType("Datetime");
            builder.Property(t => t.CreatedBy)
                    .HasColumnType("Int");
        }
    }
}