using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class EntityStatusConfig : IEntityTypeConfiguration<EntityStatus>, 
        IBaseEntityIntPKConfig<EntityStatus>,
        IGlobalCodeIdentiﬁableConfig<EntityStatus>,
        INameIdentiﬁableConfig<EntityStatus>
    {
        public void Configure(EntityTypeBuilder<EntityStatus> builder)
        {
            builder.ToTable(TableNameConst.EntityStatusConsts);

            this.BaseEntityIntPKConfigure(builder: builder, 
                shouldUseIdentityColumn: false);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 3000,
                maxLengthOfDisplayName: 3000,
                maxLengthOfSlug: 3000);

            builder.HasOne(t => t.EntityType)
                        .WithMany()
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasForeignKey(t => t.EntityTypeId);
        }
    }
}