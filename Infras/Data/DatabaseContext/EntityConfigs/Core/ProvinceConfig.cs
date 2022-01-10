using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>, 
        IBaseEntityConfig<Province, int>,
        ICodeIdentiﬁableConfig<Province>,
        INameIdentiﬁableConfig<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Provinces");
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