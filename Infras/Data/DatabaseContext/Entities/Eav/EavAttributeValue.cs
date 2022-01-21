using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav
{
    public class EavAttributeValue : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        IStatusable,
        ISoftDeletable,
        IAuditable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public int EavAttributeId { get; set; }
        public EavAttribute EavAttribute { get; set; }
        public string ValueToString { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}