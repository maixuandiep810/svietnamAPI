using Microsoft.AspNetCore.Http;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class GlobalProductCategoryCreateDto
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public int DisplayOrder { get; set; }
        public IFormFile BaseImage { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}