using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Delegation;
using Asd.AbpZeroTemplate.Authorization.Users.Delegation.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
