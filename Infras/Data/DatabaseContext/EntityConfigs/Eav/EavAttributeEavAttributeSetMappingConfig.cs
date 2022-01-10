using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeEavAttributeSetMappingConfig : IEntityTypeConfiguration<EavAttributeEavAttributeSetMapping>,
        IBaseEntityConfig<EavAttributeEavAttributeSetMapping, int>
    {
        public void Configure(EntityTypeBuilder<EavAttributeEavAttributeSetMapping> builder)
        {
            builder.ToTable("EavAttributeEavAttributeSetMappings");
            this.BaseEntityConfigure(builder: builder);
        }
    }
}