using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog
{
    public class ProductItemDetail : IBaseEntity<int>
    {
        public int Id { get; set; }
        public int ProductItemId { get; set; }
        public ProductItem ProductItem { get; set; }
        public int EavAttributeValueId { get; set; }
        public EavAttributeValue EavAttributeValue { get; set; }
    }
}