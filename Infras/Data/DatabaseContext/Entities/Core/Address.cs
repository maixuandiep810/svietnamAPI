namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Address : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; }
        public int CommuneId { get; set; }
        public Commune Commune { get; set; }
    }
}