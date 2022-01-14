using System.Collections.Generic;
namespace svietnamAPI.Common.Dtos.Core.Address
{
    public class ProvinceDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public CountryDto CountryDto { get; set; }
        
        public ICollection<DistrictDto> Districts { get; set; }
    }
}