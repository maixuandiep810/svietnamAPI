using System;
using System.Collections.Generic;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Eav
{
    public class EavAttributeDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
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
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public ICollection<EavAttributeEavAttributeSetMappingDto> EavAttributeEavAttributeSetMappings { get; set; }
        public ICollection<EavAttributeValueDto> EavAttributeValues { get; set; }
    }
}