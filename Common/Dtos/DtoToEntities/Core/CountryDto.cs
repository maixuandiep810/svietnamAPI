using System.Collections.Generic;
namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        
        public ICollection<ProvinceDto> Provinces { get; set; }
    }
}