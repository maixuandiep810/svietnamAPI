using System;

namespace svietnamAPI.Common.Dtos.Catalog
{
    public class DefaultFieldCategoryDto
    {
        public int ChildrenCount { get; set; }
        public int ProductsCount { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public DefaultFieldCategoryDto()
        {
            ChildrenCount = 0;
            ProductsCount = 0;
            IsEnabled = false;
            IsDeleted = false;
            CreatedAt = DateTime.Now;
        }
    }
}