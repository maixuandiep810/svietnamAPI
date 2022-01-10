namespace svietnamAPI.Common.Dtos.Catalog
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}