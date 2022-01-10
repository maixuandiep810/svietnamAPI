using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DistrictConfig : IEntityTypeConfiguration<District>, 
        IBaseEntityConfig<District, int>,
        ICodeIdentiﬁableConfig<District>,
        INameIdentiﬁableConfig<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.HasOne(t => t.Province)
                        .WithMany(t => t.Districts)
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasForeignKey(t => t.ProvinceId);
        }
    }
}