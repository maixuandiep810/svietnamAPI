using System;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities
{
    public interface IAuditable
    {
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}