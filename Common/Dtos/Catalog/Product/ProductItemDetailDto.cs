using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Common.Dtos.Catalog.Product
{
    public class ProductItemDetailDto
    {
        public int Id { get; set; }
        public int ProductItemId { get; set; }
        public ProductItemDto ProductItem { get; set; }
        public int EavAttributeValueId { get; set; }
        public EavAttributeValue EavAttributeValue { get; set; }
    }
}