using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
