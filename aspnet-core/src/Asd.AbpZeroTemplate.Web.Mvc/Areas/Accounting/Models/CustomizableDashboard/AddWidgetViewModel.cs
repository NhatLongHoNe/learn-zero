using System.Collections.Generic;
using Asd.AbpZeroTemplate.DashboardCustomization.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
