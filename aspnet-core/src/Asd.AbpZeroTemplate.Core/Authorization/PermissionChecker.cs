using Abp.Authorization;
using Asd.AbpZeroTemplate.Authorization.Roles;
using Asd.AbpZeroTemplate.Authorization.Users;

namespace Asd.AbpZeroTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
