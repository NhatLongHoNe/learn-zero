using System.Collections.Generic;
using Abp.Localization;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Layout
{
    public class LanguageSwitchViewModel
    {
        public IReadOnlyList<LanguageInfo> Languages { get; set; }

        public LanguageInfo CurrentLanguage { get; set; }
        
        public string CssClass { get; set; }
    }
}
