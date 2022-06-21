using AutoMapper;
using Asd.AbpZeroTemplate.Authorization.Users;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Startup
{
    public static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<User, UserDto>()
                .ForMember(dto => dto.Roles, options => options.Ignore())
                .ForMember(dto => dto.OrganizationUnits, options => options.Ignore());
        }
    }
}