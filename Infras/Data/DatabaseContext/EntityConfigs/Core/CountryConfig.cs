using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class CountryConfig : IEntityTypeConfiguration<Country>, 
        IBaseEntityIntPKConfig<Country>,
        IGlobalCodeIdentiﬁableConfig<Country>,
        INameIdentiﬁableConfig<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable(TableNameConst.Countries);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
        }
    }
}