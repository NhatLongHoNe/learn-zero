﻿using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Authorization;
using Asd.AbpZeroTemplate.DashboardCustomization;
using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Startup;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(AbpZeroTemplateDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}