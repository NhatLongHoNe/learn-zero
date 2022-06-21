using System.Collections.Generic;

namespace Asd.AbpZeroTemplate.Authorization.Roles.Dto
{
    public class GetRolesInput
    {
        public List<string> Permissions { get; set; }
    }
}
