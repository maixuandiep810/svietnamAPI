using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeSetConfig : IEntityTypeConfiguration<EavAttributeSet>,
        IBaseEntityConfig<EavAttributeSet, int>,
        ICodeIdentiﬁableConfig<EavAttributeSet>,
        INameIdentiﬁableConfig<EavAttributeSet>
    {
        public void Configure(EntityTypeBuilder<EavAttributeSet> builder)
        {
            builder.ToTable("EavAttributeSets");
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