using System.Collections.Generic;
namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Province : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public ICollection<District> Districts { get; set; }

        public Province()
        {
            Districts = new List<District>();
        }
    }
}