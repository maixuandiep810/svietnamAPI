using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.Catalog;

namespace svietnamAPI.Infras.Mapper.Catalog
{
    public static class CategoryMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            mappingProfile.CreateMap<Category, CategoryDto>(MemberList.Destination);
            mappingProfile.CreateMap<CreateCategoryDto, Category>(MemberList.Source);
            mappingProfile.CreateMap<DefaultFieldCategoryDto, Category>(MemberList.Source);
        }
    }
}