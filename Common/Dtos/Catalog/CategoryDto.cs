using System;
using svietnamAPI.Common.Dtos.Core;

namespace svietnamAPI.Common.Dtos.Catalog
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public int ChildrenCount { get; set; }
        public int ProductsCount { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int BaseImageId { get; set; }
        public virtual DocumentDto BaseImage { get; set; }
        public int ThumbnailImageId { get; set; }
        public virtual DocumentDto ThumbnailImage { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}