using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace Asd.AbpZeroTemplate.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
