namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttributeValue : IBaseEntity<int>
    {
        public int Id { get; set; }
        public int EavAttributeId { get; set; }
        public EavAttribute EavAttribute { get; set; }
        public string ValueToString { get; set; }
    }
}