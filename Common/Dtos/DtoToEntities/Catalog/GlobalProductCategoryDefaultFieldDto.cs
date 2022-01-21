using System;
using svietnamAPI.Common.Dtos.Values;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class GlobalProductCategoryDefaultFieldDto
    {
        public int ChildrenCount { get; set; }
        public int ProductsCount { get; set; }
        public int EntityStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }

        public GlobalProductCategoryDefaultFieldDto()
        {
            ChildrenCount = 0;
            ProductsCount = 0;
            EntityStatusId = EntityStatusConst.GlobalProductCategory_Pending.Id;
            IsDeleted = false;
            CreatedAt = DateTime.Now;
        }
    }
}