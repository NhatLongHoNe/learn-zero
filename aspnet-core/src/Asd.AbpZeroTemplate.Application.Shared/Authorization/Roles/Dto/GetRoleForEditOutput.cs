using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace Asd.AbpZeroTemplate.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}