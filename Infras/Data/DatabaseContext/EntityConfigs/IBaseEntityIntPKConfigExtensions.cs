using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Infras.Common.Values.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IBaseEntityIntPKConfigExtensions
    {
        public static void BaseEntityIntPKConfigure<TEntity>(this IBaseEntityIntPKConfig<TEntity> entityConfig,
            EntityTypeBuilder<TEntity> builder,
            bool shouldUseIdentityColumn = true)
            where TEntity : class, IBaseEntity<int>
        {
            builder.HasKey(o => o.Id);

            if (shouldUseIdentityColumn == true)
            {
                builder.Property(p => p.Id)
                        .UseIdentityColumn(seed: ColumnConstraintConst.IntPKSeed, 
                            increment: ColumnConstraintConst.IntPKIncrement);
            }
        }
    }
}