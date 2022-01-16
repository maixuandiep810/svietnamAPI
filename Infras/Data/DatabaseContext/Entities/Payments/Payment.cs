using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineOrders;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Payments
{
    public class Payment : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        IStoreCodeIdentiﬁable,
        IStatusable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string StoreCode { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
        public decimal PaymentFee { get; set; }
        public string FailureMessage { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}