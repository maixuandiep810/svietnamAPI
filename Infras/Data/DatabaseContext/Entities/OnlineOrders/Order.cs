using System.Collections;
using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Auth;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineOrders
{
    public class Order: IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        IStoreCodeIdentiﬁable,
        IStatusable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string StoreCode { get; set; }
        public bool IsRoot { get; set; }
        public int? ParentId { get; set; }
        public Order Parent { get; set; }
        public int BuyerId { get; set; }
        public User Buyer { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public int BillingAddressingId { get; set; }
        public Address BillingAddress { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderNote { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public ICollection<Order> Children { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            Children = new List<Order>();
            OrderItems = new List<OrderItem>();
        }
    }
}