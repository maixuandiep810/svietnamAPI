namespace svietnamAPI.Infras.Data.DatabaseContext.Entities
{
    public interface IBaseEntity<TId>
    where TId: struct
    {
        TId Id { get; set; }
    }
}