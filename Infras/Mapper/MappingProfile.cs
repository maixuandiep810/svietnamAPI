using AutoMapper;
using svietnamAPI.Infras.Mapper.EntityMappingProfile;

namespace svietnamAPI.Infras.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CoreMappingProfile.CreateMap(this);
            EavMappingProfile.CreateMap(this);
            CatalogMappingProfile.CreateMap(this);
        }
    }
}