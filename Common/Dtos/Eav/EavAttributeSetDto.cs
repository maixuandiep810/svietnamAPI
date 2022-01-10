using System.Collections.Generic;

namespace svietnamAPI.Common.Dtos.Eav
{
    public class EavAttributeSetDto 
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public ICollection<EavAttributeEavAttributeSetMappingDto> EavAttributeEavAttributeSetMappings { get; set; }
    }
}