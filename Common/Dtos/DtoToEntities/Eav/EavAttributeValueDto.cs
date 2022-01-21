using System;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Eav
{
    public class EavAttributeValueDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public int EavAttributeId { get; set; }
        public EavAttributeDto EavAttribute { get; set; }
        public string ValueToString { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}