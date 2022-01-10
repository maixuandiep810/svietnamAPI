using AutoMapper;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Common.Dtos.Core.Document;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;
using svietnamAPI.Common.Dtos.Eav;

namespace svietnamAPI.Infras.Mapper.EntityMappingProfile
{
    public static class EavMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            mappingProfile.CreateMap<EavAttribute, EavAttributeDto>(MemberList.Destination);
            mappingProfile.CreateMap<EavAttributeEavAttributeSetMapping, EavAttributeEavAttributeSetMappingDto>(MemberList.Destination);
            mappingProfile.CreateMap<EavAttributeGroup, EavAttributeGroupDto>(MemberList.Destination);
            mappingProfile.CreateMap<EavAttributeSet, EavAttributeSetDto>(MemberList.Destination);
            mappingProfile.CreateMap<EavAttributeValue, EavAttributeValueDto>(MemberList.Destination);
        }
    }
}