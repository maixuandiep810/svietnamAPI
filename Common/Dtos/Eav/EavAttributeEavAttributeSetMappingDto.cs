namespace svietnamAPI.Common.Dtos.Eav
{
    public class EavAttributeEavAttributeSetMappingDto
    {
        public int Id { get; set; }
        public int EavAttributeId { get; set; }
        public EavAttributeDto EavAttribute { get; set; }
        public int EavAttributeSetId { get; set; }
        public EavAttributeSetDto EavAttributeSet { get; set; }
    }
}