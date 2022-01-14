using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DistrictConfig : IEntityTypeConfiguration<District>, 
        IBaseEntityIntPKConfig<District>,
        IGlobalCodeIdentiﬁableConfig<District>,
        INameIdentiﬁableConfig<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(TableNameConst.Districts);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);

            builder.HasOne(t => t.Province)
                        .WithMany(t => t.Districts)
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasForeignKey(t => t.ProvinceId);
        }
    }
}