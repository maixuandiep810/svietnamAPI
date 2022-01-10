using System.Collections.Generic;
using System;
using svietnamAPI.Common.Dtos.Core.EntityType;

namespace svietnamAPI.Common.Dtos.Catalog.Product
{
    public class ProductItemDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int OutOfStockThreshold { get; set; }
        public int NotifyForQuantityBelow { get; set; }
        public int MinQtyAllowedInShoppingCart { get; set; }
        public int MaxQtyAllowedInShoppingCart { get; set; }
        public int DisplayOrder { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public ICollection<ProductItemDetailDto> ProductItemDetails { get; set; }
    }
}