using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores
{
    public class StoreProductCategory : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        IStoreCodeIdentiﬁable,
        IStatusable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string StoreCode { get; set; }
        public int GlobalProductCategoryId { get; set; }
        public GlobalProductCategory GlobalProductCategory { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int DisplayOrder { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}