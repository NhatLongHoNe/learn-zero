using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Authorization.Users;
using Asd.AbpZeroTemplate.Authorization.Users.Dto;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}