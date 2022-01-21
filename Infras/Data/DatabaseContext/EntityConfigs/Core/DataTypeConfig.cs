using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core
{
    public class DataTypeConfig : IEntityTypeConfiguration<DataType>,
        IBaseEntityIntPKConfig<DataType>,
        IGlobalCodeIdentiﬁableConfig<DataType>,
        INameIdentiﬁableConfig<DataType>
    {
        public void Configure(EntityTypeBuilder<DataType> builder)
        {
            builder.ToTable(TableNameConst.DataTypeConsts);
            
            this.BaseEntityIntPKConfigure(builder: builder, 
                shouldUseIdentityColumn: false);
            this.GlobalCodeIdentiﬁableConfigure(builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);

            builder.Property(t => t.BackendName)
                    .HasColumnType(ColumnTypeConst.Nvarchar)
                    .HasMaxLength(100)
                    .IsRequired();
        }
    }
}