using System.Collections.Generic;
namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public ICollection<Province> Provinces { get; set; }
    }
}