using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Layout;
using Asd.AbpZeroTemplate.Web.Views;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Views.Shared.Components.AccountingLanguageSwitch
{
    public class AccountingLanguageSwitchViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AccountingLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
