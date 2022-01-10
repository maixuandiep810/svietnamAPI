using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog
{
    public class Product : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable,
        IAuditable,
        ISoftDeletable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int LeafCategoryId { get; set; }
        public Category LeafCategory { get; set; }
        public int ItemsCount { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public ICollection<ProductItem> ProductItems { get; set; }

        public Product()
        {
            ProductItems = new List<ProductItem>();
        }
    }
}