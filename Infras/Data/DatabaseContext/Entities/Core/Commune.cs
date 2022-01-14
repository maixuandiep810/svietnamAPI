using System.Collections;
using System.Collections.Generic;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Commune : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public Commune()
        {
            Addresses = new List<Address>();
        }
    }
}