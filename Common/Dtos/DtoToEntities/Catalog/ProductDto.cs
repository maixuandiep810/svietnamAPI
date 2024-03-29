using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string StoreCode { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int LeafCategoryId { get; set; }
        public GlobalProductCategoryDto LeafCategory { get; set; }
        public int DisplayOrder { get; set; }
        public int ItemsCount { get; set; }
        public int StoreId { get; set; }
        // public StoreDto Store { get; set; }
        public int CountryOfOriginId { get; set; }
        public Country CountryOfOrigin { get; set; }
        public int ManufacturerId { get; set; }
        public ManufacturerDto Manufacturer { get; set; }
        public int? SupplierId { get; set; }
        public SupplierDto Supplier { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public ICollection<ProductItemDto> ProductItems { get; set; }
    }
}