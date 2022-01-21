namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class CommuneDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int DistrictId { get; set; }
        public DistrictDto District { get; set; }
    }
}