using System.Collections.Generic;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttribute : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string Code { get; set; }
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
        public ICollection<EavAttributeEavAttributeSetMapping> EavAttributeEavAttributeSetMappings { get; set; }

        public EavAttribute()
        {
            EavAttributeEavAttributeSetMappings = new List<EavAttributeEavAttributeSetMapping>();
        }
    }
}