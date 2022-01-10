using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog
{
    public class ProductItem : IBaseEntity<int>,
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
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int OutOfStockThreshold { get; set; }
        public int NotifyForQuantityBelow { get; set; }
        public int MinQtyAllowedInShoppingCart { get; set; }
        public int MaxQtyAllowedInShoppingCart { get; set; }
        public int DisplayOrder { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public ICollection<ProductItemDetail> ProductItemDetails { get; set; }

        public ProductItem()
        {
            ProductItemDetails = new List<ProductItemDetail>();
        }
    }
}