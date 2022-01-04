namespace svietnamAPI.Infras.Data.DatabaseContext.Entities
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}