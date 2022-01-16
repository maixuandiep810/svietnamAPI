using System.Collections.Generic;
using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Auth;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.OnlineStores
{
    public class Store: IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        IStoreCodeIdentiﬁable,
        INameIdentiﬁable,
        IStatusable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string StoreCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public ICollection<StoreSeller> StoreSellers { get; set; }
        public ICollection<StoreProductCategory> StoreProductCategories { get; set; }
        public ICollection<Product> Products { get; set; }

        public Store()
        {
            StoreSellers = new List<StoreSeller>();
            StoreProductCategories = new List<StoreProductCategory>();
            Products = new List<Product>();
        }
    }
}