using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Common.Dtos.Core;

namespace svietnamAPI.Infras.Mapper.Core
{
    public static class CoreMappingProfile
    {
        public static void CreateMap(MappingProfile mappingProfile)
        {
            mappingProfile.CreateMap<DocumentType, DocumentTypeDto>(MemberList.Destination);
            mappingProfile.CreateMap<Document, DocumentDto>(MemberList.Destination);
        }
    }
}