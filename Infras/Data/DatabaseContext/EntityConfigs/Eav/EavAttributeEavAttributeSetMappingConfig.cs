using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeEavAttributeSetMappingConfig : IEntityTypeConfiguration<EavAttributeEavAttributeSetMapping>,
        IBaseEntityIntPKConfig<EavAttributeEavAttributeSetMapping>
    {
        public void Configure(EntityTypeBuilder<EavAttributeEavAttributeSetMapping> builder)
        {
            builder.ToTable(TableNameConst.EavAttributeEavAttributeSetMappings);

            this.BaseEntityIntPKConfigure(builder);

            builder.HasOne(p => p.EavAttributeSet)
                    .WithMany(p => p.EavAttributeEavAttributeSetMappings)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EavAttributeSetId);
            builder.HasOne(p => p.EavAttribute)
                    .WithMany(p => p.EavAttributeEavAttributeSetMappings)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(p => p.EavAttributeId);
        }
    }
}