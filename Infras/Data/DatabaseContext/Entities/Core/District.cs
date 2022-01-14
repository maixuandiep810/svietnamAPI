using System.Collections.Generic;
namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class District : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        public ICollection<Commune> Communes { get; set; }
        
        public District()
        {
            Communes = new List<Commune>();
        }
    }
}