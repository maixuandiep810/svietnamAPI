namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; }
        public int? CommuneId { get; set; }
        public CommuneDto Commune { get; set; }
        public int? DistrictId { get; set; }
        public DistrictDto District { get; set; }
        public int? ProvinceId { get; set; }
        public ProvinceDto Province { get; set; }
        public int? CountryId { get; set; }
        public CountryDto Country { get; set; }
    }
}