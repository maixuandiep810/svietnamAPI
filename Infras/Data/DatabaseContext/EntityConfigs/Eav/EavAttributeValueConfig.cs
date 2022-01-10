using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeValueConfig : IEntityTypeConfiguration<EavAttributeValue>,
        IBaseEntityConfig<EavAttributeValue, int>
    {
        public void Configure(EntityTypeBuilder<EavAttributeValue> builder)
        {
            builder.ToTable("EavAttributeValues");
            this.BaseEntityConfigure(builder: builder);
        }
    }
}