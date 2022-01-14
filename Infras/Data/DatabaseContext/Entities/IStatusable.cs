using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities
{
    public interface IStatusable
    {
        int EntityStatusId { get; set; }
        EntityStatus EntityStatus { get; set; }
    }
}