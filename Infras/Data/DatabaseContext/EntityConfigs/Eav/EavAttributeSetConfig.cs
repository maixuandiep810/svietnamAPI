using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeSetConfig : IEntityTypeConfiguration<EavAttributeSet>,
        IBaseEntityIntPKConfig<EavAttributeSet>,
        IGlobalCodeIdentiﬁableConfig<EavAttributeSet>,
        INameIdentiﬁableConfig<EavAttributeSet>
    {
        public void Configure(EntityTypeBuilder<EavAttributeSet> builder)
        {
            builder.ToTable(TableNameConst.EavAttributeSets);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
        }
    }
}