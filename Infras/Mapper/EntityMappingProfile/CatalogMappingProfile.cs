using AutoMapper;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.Catalog.Category;
using svietnamAPI.Common.Dtos.Catalog.Product;
using svietnamAPI.Common.Dtos.Catalog.Supplier;

namespace svietnamAPI.Infras.Mapper.EntityMappingProfile
{
    public static class CatalogMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            //
            //
            //  Category
            //
            //
            // mappingProfile.CreateMap<Category, CategoryDto>(MemberList.Destination);
            // mappingProfile.CreateMap<CreateCategoryDto, Category>(MemberList.Source);
            // mappingProfile.CreateMap<DefaultFieldCategoryDto, Category>(MemberList.Source);
            //
            //
            //  Product
            //
            //
            mappingProfile.CreateMap<Product, ProductDto>(MemberList.Destination);
            mappingProfile.CreateMap<ProductItem, ProductItemDto>(MemberList.Destination);
            mappingProfile.CreateMap<ProductItemDetail, ProductItemDetailDto>(MemberList.Destination);
            //
            //
            //  Supplier
            //
            //
            mappingProfile.CreateMap<Manufacturer, ManufacturerDto>(MemberList.Destination);
            mappingProfile.CreateMap<Supplier, SupplierDto>(MemberList.Destination);
        }
    }
}