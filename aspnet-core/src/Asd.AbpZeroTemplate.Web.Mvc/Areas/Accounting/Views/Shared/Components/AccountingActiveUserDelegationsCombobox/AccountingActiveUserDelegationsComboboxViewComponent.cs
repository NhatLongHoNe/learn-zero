using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Authorization.Delegation;
using Asd.AbpZeroTemplate.Authorization.Users.Delegation;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Layout;
using Asd.AbpZeroTemplate.Web.Views;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Views.Shared.Components.AccountingActiveUserDelegationsCombobox
{
    public class AccountingActiveUserDelegationsComboboxViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;

        public AccountingActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService, 
            IUserDelegationConfiguration userDelegationConfiguration)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
            var model = new ActiveUserDelegationsComboboxViewModel
            {
                UserDelegations = activeUserDelegations,
                UserDelegationConfiguration = _userDelegationConfiguration
            };

            return View(model);
        }
    }
}
