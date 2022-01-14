using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using svietnamAPI.Infras.Common.Values.DatabaseContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;

namespace svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs
{
    public static class IStatusableConfigExtensions
    {
        public static void StatusableConfigure<TEntity>(this IStatusableConfig<TEntity> entityConfig,
            EntityTypeBuilder<TEntity> builder)
            where TEntity : class, IStatusable
        {

        }
    }
}