using AutoMapper;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Mapper.EntityMappingProfile
{
    public static class CatalogMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            //
            //  Category
            //

            mappingProfile.CreateMap<GlobalProductCategory, GlobalProductCategoryDto>(MemberList.Destination);
            mappingProfile.CreateMap<GlobalProductCategory, GlobalProductCategorySummaryDto>(MemberList.Destination);

            mappingProfile.CreateMap<GlobalProductCategoryCreateDto, GlobalProductCategory>(MemberList.Source)
                .ForMember(s => s.BaseImage, o => o.Ignore())
                .ForMember(s => s.ThumbnailImage, o => o.Ignore());
            mappingProfile.CreateMap<GlobalProductCategoryDefaultFieldDto, GlobalProductCategory>(MemberList.Source);

            //
            //  Product
            //

            mappingProfile.CreateMap<Product, ProductDto>(MemberList.Destination);
            mappingProfile.CreateMap<ProductItem, ProductItemDto>(MemberList.Destination);
            mappingProfile.CreateMap<ProductItemDetail, ProductItemDetailDto>(MemberList.Destination);
            
            //
            //  Supplier
            //

            mappingProfile.CreateMap<Manufacturer, ManufacturerDto>(MemberList.Destination);
            mappingProfile.CreateMap<Supplier, SupplierDto>(MemberList.Destination);
        }
    }
}