using System.Collections.Generic;
namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttributeSet : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public ICollection<EavAttributeEavAttributeSetMapping> EavAttributeEavAttributeSetMappings { get; set; }

        public EavAttributeSet()
        {
            EavAttributeEavAttributeSetMappings = new List<EavAttributeEavAttributeSetMapping>();
        }
    }
}