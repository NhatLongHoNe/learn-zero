using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace Asd.AbpZeroTemplate.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}