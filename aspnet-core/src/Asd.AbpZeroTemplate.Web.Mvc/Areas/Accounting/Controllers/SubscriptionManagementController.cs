using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Authorization;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Editions;
using Asd.AbpZeroTemplate.Web.Controllers;
using Asd.AbpZeroTemplate.Web.Session;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)]
    public class SubscriptionManagementController : AbpZeroTemplateControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public SubscriptionManagementController(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<ActionResult> Index()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            var model = new SubscriptionDashboardViewModel
            {
                LoginInformations = loginInfo
            };

            return View(model);
        }
    }
}