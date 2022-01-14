using System.Collections.Generic;
namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttributeGroup : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        
        public ICollection<EavAttribute> EavAttributes { get; set; }

        public EavAttributeGroup()
        {
            EavAttributes = new List<EavAttribute>();
        }
    }
}