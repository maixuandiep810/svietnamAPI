using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class EntityStatusConfig : IEntityTypeConfiguration<EntityStatus>, 
        IBaseEntityConfig<EntityStatus, int>,
        ICodeIdentiﬁableConfig<EntityStatus>,
        INameIdentiﬁableConfig<EntityStatus>
    {
        public void Configure(EntityTypeBuilder<EntityStatus> builder)
        {
            builder.ToTable("EntityStatuses");
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