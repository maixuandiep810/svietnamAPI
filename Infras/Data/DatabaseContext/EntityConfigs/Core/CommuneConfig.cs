using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class CommuneConfig : IEntityTypeConfiguration<Commune>, 
        IBaseEntityConfig<Commune, int>,
        ICodeIdentiﬁableConfig<Commune>,
        INameIdentiﬁableConfig<Commune>
    {
        public void Configure(EntityTypeBuilder<Commune> builder)
        {
            builder.ToTable("Communes");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.HasOne(t => t.District)
                        .WithMany(t => t.Communes)
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasForeignKey(t => t.DistrictId);
        }
    }
}