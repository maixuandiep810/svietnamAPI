using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class EntityTypeConfig : IEntityTypeConfiguration<EntityType>,
        IBaseEntityConfig<EntityType, int>,
        ICodeIdentiﬁableConfig<EntityType>,
        INameIdentiﬁableConfig<EntityType>
    {
        public void Configure(EntityTypeBuilder<EntityType> builder)
        {
            builder.ToTable("EntityTypes");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.Property(t => t.IsEavEntity)
                    .HasColumnType("Bit")
                    .HasDefaultValue(false);
        }
    }
}