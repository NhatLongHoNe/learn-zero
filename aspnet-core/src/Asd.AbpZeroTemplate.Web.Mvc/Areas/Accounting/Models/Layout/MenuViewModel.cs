using Abp.Application.Navigation;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}