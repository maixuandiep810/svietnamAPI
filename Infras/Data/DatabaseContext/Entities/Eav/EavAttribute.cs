using System.Collections;
using System;
using System.Collections.Generic;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttribute : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        INameIdentiﬁable,
        IStatusable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public bool IsRequired { get; set; }
        public int DataTypeId { get; set; }
        public DataType DataType { get; set; }
        public int EntityTypeId { get; set; }
        public EntityType EntityType { get; set; }
        public int EavAttributeGroupId { get; set; }
        public EavAttributeGroup EavAttributeGroup { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public ICollection<EavAttributeEavAttributeSetMapping> EavAttributeEavAttributeSetMappings { get; set; }
        public ICollection<EavAttributeValue> EavAttributeValues { get; set; }

        public EavAttribute()
        {
            EavAttributeEavAttributeSetMappings = new List<EavAttributeEavAttributeSetMapping>();
            EavAttributeValues = new List<EavAttributeValue>();
        }
    }
}