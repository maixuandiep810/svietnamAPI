using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class CommuneConfig : IEntityTypeConfiguration<Commune>, 
        IBaseEntityIntPKConfig<Commune>,
        IGlobalCodeIdentiﬁableConfig<Commune>,
        INameIdentiﬁableConfig<Commune>
    {
        public void Configure(EntityTypeBuilder<Commune> builder)
        {
            builder.ToTable(TableNameConst.Communes);

            this.BaseEntityIntPKConfigure(builder);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 3000,
                maxLengthOfDisplayName: 3000,
                maxLengthOfSlug: 3000);

            builder.HasOne(t => t.District)
                        .WithMany(t => t.Communes)
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasForeignKey(t => t.DistrictId);
        }
    }
}