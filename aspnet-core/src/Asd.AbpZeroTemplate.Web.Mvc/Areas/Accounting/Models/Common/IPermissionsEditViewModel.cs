using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}