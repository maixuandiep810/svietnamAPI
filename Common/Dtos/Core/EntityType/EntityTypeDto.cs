namespace svietnamAPI.Common.Dtos.Core.EntityType
{
    public class EntityTypeDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public bool IsEavEntity { get; set; }
    }
}