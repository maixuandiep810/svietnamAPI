using System;
using System.Collections.Generic;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class GlobalProductCategoryDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public GlobalProductCategoryDto Parent { get; set; }
        public int ChildrenCount { get; set; }
        public int ProductsCount { get; set; }
        public int DisplayOrder { get; set; }
        public int BaseImageId { get; set; }
        public DocumentDto BaseImage { get; set; }
        public int ThumbnailImageId { get; set; }
        public DocumentDto ThumbnailImage { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        
        public ICollection<GlobalProductCategoryDto> Children { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}