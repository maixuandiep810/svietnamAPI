using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Auth
{
    public class AddressBook : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        ISoftDeletable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
    }
}