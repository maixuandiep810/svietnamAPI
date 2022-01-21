using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeGroupConfig : IEntityTypeConfiguration<EavAttributeGroup>,
        IBaseEntityIntPKConfig<EavAttributeGroup>,
        IGlobalCodeIdentiﬁableConfig<EavAttributeGroup>,
        INameIdentiﬁableConfig<EavAttributeGroup>
    {
        public void Configure(EntityTypeBuilder<EavAttributeGroup> builder)
        {
            builder.ToTable(TableNameConst.EavAttributeGroupConsts);
            
            this.BaseEntityIntPKConfigure(builder: builder, 
                shouldUseIdentityColumn: false);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
        }
    }
}