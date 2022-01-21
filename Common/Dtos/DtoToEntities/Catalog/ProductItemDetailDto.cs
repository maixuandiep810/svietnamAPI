using System;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class ProductItemDetailDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string StoreCode { get; set; }
        public int ProductItemId { get; set; }
        public ProductItemDto ProductItem { get; set; }
        public int EavAttributeValueId { get; set; }
        public EavAttributeValue EavAttributeValue { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}