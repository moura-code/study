using AutoMapper;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
     CreateMap<Platform,PlatformReadDto>();
    }
}