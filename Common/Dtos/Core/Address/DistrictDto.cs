using System.Collections.Generic;
namespace svietnamAPI.Common.Dtos.Core.Address
{
    public class DistrictDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int ProvinceId { get; set; }
        public ProvinceDto Province { get; set; }

        public ICollection<CommuneDto> Communes { get; set; }    
    }
}