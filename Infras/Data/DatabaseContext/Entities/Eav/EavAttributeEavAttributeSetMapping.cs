namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttributeEavAttributeSetMapping : IBaseEntity<int>
    {
        public int Id { get; set; }
        public int EavAttributeId { get; set; }
        public EavAttribute EavAttribute { get; set; }
        public int EavAttributeSetId { get; set; }
        public EavAttributeSet EavAttributeSet { get; set; }
    }
}