using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DataTypeConfig : IEntityTypeConfiguration<DataType>, 
        IBaseEntityConfig<DataType, int>,
        ICodeIdentiﬁableConfig<DataType>,
        INameIdentiﬁableConfig<DataType>
    {
        public void Configure(EntityTypeBuilder<DataType> builder)
        {
            builder.ToTable("DataTypes");
            this.BaseEntityConfigure(builder: builder);
            this.CodeIdentiﬁableConfigure(builder: builder,
                maxCodeLength: 3000);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxNameLength: 3000,
                maxDisplayNameLength: 3000,
                maxSlugLength: 3000);
            builder.Property(t => t.BackendName)
                    .HasColumnType("Varchar")
                    .HasMaxLength(3000)
                    .HasDefaultValue(false);
        }
    }
}