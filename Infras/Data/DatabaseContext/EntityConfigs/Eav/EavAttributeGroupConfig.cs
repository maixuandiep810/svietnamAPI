using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeGroupConfig : IEntityTypeConfiguration<EavAttributeGroup>,
        IBaseEntityConfig<EavAttributeGroup, int>,
        ICodeIdentiﬁableConfig<EavAttributeGroup>,
        INameIdentiﬁableConfig<EavAttributeGroup>
    {
        public void Configure(EntityTypeBuilder<EavAttributeGroup> builder)
        {
            builder.ToTable("EavAttributeGroups");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
        }
    }
}