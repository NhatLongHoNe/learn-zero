using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Authorization.Roles.Dto;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}