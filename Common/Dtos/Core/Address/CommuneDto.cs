namespace svietnamAPI.Common.Dtos.Core.Address
{
    public class CommuneDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int DistrictId { get; set; }
        public DistrictDto District { get; set; }
    }
}