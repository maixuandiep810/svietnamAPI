using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Common.Dtos.Catalog.Supplier
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}