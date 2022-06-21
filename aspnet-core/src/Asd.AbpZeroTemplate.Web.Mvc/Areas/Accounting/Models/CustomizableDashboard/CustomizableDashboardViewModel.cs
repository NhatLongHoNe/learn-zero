using Asd.AbpZeroTemplate.DashboardCustomization;
using Asd.AbpZeroTemplate.DashboardCustomization.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.CustomizableDashboard
{
    public class CustomizableDashboardViewModel
    {
        public DashboardOutput DashboardOutput { get; }

        public Dashboard UserDashboard { get; }

        public CustomizableDashboardViewModel(
            DashboardOutput dashboardOutput,
            Dashboard userDashboard)
        {
            DashboardOutput = dashboardOutput;
            UserDashboard = userDashboard;
        }
    }
}