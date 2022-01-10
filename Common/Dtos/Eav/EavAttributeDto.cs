using System.Collections.Generic;
using svietnamAPI.Common.Dtos.Core.EntityType;

namespace svietnamAPI.Common.Dtos.Eav
{
    public class EavAttributeDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public bool IsRequired { get; set; }
        public int DataTypeId { get; set; }
        public DataTypeDto DataType { get; set; }
        public int EntityTypeId { get; set; }
        public EntityTypeDto EntityType { get; set; }
        public int EavAttributeGroupId { get; set; }
        public EavAttributeGroupDto EavAttributeGroup { get; set; }
        public ICollection<EavAttributeEavAttributeSetMappingDto> EavAttributeEavAttributeSetMappings { get; set; }
    }
}