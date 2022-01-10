using System;

namespace svietnamAPI.Common.Dtos.Catalog.Category
{
    public class DefaultFieldCategoryDto
    {
        public int ChildrenCount { get; set; }
        public int ProductsCount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public DefaultFieldCategoryDto()
        {
            ChildrenCount = 0;
            ProductsCount = 0;
            IsDeleted = false;
            CreatedAt = DateTime.Now;
        }
    }
}