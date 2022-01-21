using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int AddressId { get; set; }
        public AddressDto Address { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
    }
}