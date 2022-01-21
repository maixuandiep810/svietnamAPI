using System.Collections.Generic;
using System;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class ProductItemDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string StoreCode { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public decimal ProductItemPrice { get; set; }
        public int Quantity { get; set; }
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
        // public ICollection<OrderItem> OrderItems { get; set; }
    }
}