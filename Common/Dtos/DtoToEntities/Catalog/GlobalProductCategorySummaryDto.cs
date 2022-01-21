using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Catalog
{
    public class GlobalProductCategorySummaryDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public int DisplayOrder { get; set; }

        //     public GlobalProductCategorySummaryDto(GlobalProductCategory globalPC)
        //     {
        //         this.
        //         this.GlobalCode = globalPC.GlobalCode;
        //         this.Name = globalPC.Name;
        //         this.DisplayName =
        //         this.Slug =
        //         this.IsRoot =
        //         this.IsLeaf =
        //         this.ParentId =
        //         this.DisplayOrder =
        // }
    }
}