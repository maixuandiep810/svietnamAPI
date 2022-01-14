using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class EntityTypeConfig : IEntityTypeConfiguration<EntityType>,
        IBaseEntityIntPKConfig<EntityType>,
        IGlobalCodeIdentiﬁableConfig<EntityType>,
        INameIdentiﬁableConfig<EntityType>
    {
        public void Configure(EntityTypeBuilder<EntityType> builder)
        {
            builder.ToTable(TableNameConst.EntityTypes);
            
            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
        }
    }
}