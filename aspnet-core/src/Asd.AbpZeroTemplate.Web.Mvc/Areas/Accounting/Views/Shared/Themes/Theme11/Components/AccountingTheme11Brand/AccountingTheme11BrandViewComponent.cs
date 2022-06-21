using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Layout;
using Asd.AbpZeroTemplate.Web.Session;
using Asd.AbpZeroTemplate.Web.Views;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Views.Shared.Themes.Theme11.Components.AccountingTheme11Brand
{
    public class AccountingTheme11BrandViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountingTheme11BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
