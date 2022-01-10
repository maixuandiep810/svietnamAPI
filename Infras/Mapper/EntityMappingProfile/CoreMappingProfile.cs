using AutoMapper;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Common.Dtos.Core.Document;
using svietnamAPI.Common.Dtos.Core.Address;
using svietnamAPI.Common.Dtos.Core.EntityType;

namespace svietnamAPI.Infras.Mapper.EntityMappingProfile
{
    public static class CoreMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            //
            //
            //  Address
            //
            //
            mappingProfile.CreateMap<Address, AddressDto>(MemberList.Destination);
            mappingProfile.CreateMap<Commune, CommuneDto>(MemberList.Destination);
            mappingProfile.CreateMap<District, DistrictDto>(MemberList.Destination);
            mappingProfile.CreateMap<Province, ProvinceDto>(MemberList.Destination);
            //
            //
            //  Document
            //
            //
            mappingProfile.CreateMap<DocumentType, DocumentTypeDto>(MemberList.Destination);
            mappingProfile.CreateMap<Document, DocumentDto>(MemberList.Destination);
            //
            //
            //  EntityType
            //
            //
            mappingProfile.CreateMap<DataType, DataTypeDto>(MemberList.Destination);
            mappingProfile.CreateMap<EntityStatus, EntityStatusDto>(MemberList.Destination);
            mappingProfile.CreateMap<EntityType, EntityTypeDto>(MemberList.Destination);
        }
    }
}