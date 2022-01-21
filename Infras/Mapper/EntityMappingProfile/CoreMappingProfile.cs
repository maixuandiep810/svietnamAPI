using AutoMapper;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Infras.Mapper.EntityMappingProfile
{
    public static class CoreMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            //
            //  Address
            //

            mappingProfile.CreateMap<Address, AddressDto>(MemberList.Destination);
            mappingProfile.CreateMap<Commune, CommuneDto>(MemberList.Destination);
            mappingProfile.CreateMap<District, DistrictDto>(MemberList.Destination);
            mappingProfile.CreateMap<Province, ProvinceDto>(MemberList.Destination);
            mappingProfile.CreateMap<Country, CountryDto>(MemberList.Destination);
            
            //
            //  Document
            //

            mappingProfile.CreateMap<DocumentType, DocumentTypeDto>(MemberList.Destination);
            mappingProfile.CreateMap<Document, DocumentDto>(MemberList.Destination);
            mappingProfile.CreateMap<DocumentCreateDto, Document>(MemberList.Source);
            mappingProfile.CreateMap<DocumentDefaultFieldDto, Document>(MemberList.Source);

            //
            //  EntityType
            //

            mappingProfile.CreateMap<DataType, DataTypeDto>(MemberList.Destination);
            mappingProfile.CreateMap<EntityStatus, EntityStatusDto>(MemberList.Destination);
            mappingProfile.CreateMap<EntityType, EntityTypeDto>(MemberList.Destination);
        }
    }
}