using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog
{
    public class Category : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public int ChildrenCount { get; set; }
        public int ProductsCount { get; set; }
        public int BaseImageId { get; set; }
        public Document BaseImage { get; set; }
        public int ThumbnailImageId { get; set; }
        public Document ThumbnailImage { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}