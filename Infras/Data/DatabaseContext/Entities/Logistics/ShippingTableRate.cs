using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Logistics
{
    public class ShippingTableRate : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        IStoreCodeIdentiﬁable,
        IStatusable,
        IAuditable,
        ISoftDeletable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string StoreCode { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int? CommuneId { get; set; }
        public Commune Commune { get; set; }
        public int? DistricId { get; set; }
        public District District { get; set; }
        public int? ProvinceId { get; set; }
        public Province Province { get; set; }
        public decimal MinOrderSubTotal { get; set; }
        public decimal ShippingPrice { get; set; }
        public string Description { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}