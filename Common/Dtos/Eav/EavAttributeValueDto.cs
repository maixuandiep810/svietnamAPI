namespace svietnamAPI.Common.Dtos.Eav
{
    public class EavAttributeValueDto
    {
        public int Id { get; set; }
        public int EavAttributeId { get; set; }
        public EavAttributeDto EavAttribute { get; set; }
        public string ValueToString { get; set; }
    }
}