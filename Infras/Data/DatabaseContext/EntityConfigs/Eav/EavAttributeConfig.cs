using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav
{
    public class EavAttributeConfig : IEntityTypeConfiguration<EavAttribute>,
        IBaseEntityIntPKConfig<EavAttribute>,
        IGlobalCodeIdentiﬁableConfig<EavAttribute>,
        INameIdentiﬁableConfig<EavAttribute>,
        IStatusableConfig<EavAttribute>,
        ISoftDeletableConfig<EavAttribute>,
        IAuditableConfig<EavAttribute>
    {
        public void Configure(EntityTypeBuilder<EavAttribute> builder)
        {
            builder.ToTable(TableNameConst.EavAttributes);

            this.BaseEntityIntPKConfigure(builder: builder);
            this.GlobalCodeIdentiﬁableConfigure(builder: builder);
            this.NameIdentiﬁableConfigure(builder: builder,
                maxLengthOfName: 100,
                maxLengthOfDisplayName: 100,
                maxLengthOfSlug: 100);
            this.StatusableConfigure(builder: builder);
            this.SoftDeletableConfigure(builder: builder);
            this.AuditableConfigure(builder: builder);
        }
    }
}