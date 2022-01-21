using System;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Address : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        INameIdentiﬁable
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
        public Commune Commune { get; set; }
        public int? DistrictId { get; set; }
        public District District { get; set; }
        public int? ProvinceId { get; set; }
        public Province Province { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}