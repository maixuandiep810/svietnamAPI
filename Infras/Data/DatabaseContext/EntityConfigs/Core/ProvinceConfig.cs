using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>, 
        IBaseEntityIntPKConfig<Province>,
        IGlobalCodeIdentiﬁableConfig<Province>,
        INameIdentiﬁableConfig<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable(TableNameConst.Provinces);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);

            builder.HasOne(t => t.Country)
                        .WithMany(t => t.Provinces)
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasForeignKey(t => t.CountryId);
        }
    }
}