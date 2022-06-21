using System.Collections.Generic;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Languages
{
    public class LanguageTextsViewModel
    {
        public string LanguageName { get; set; }

        public List<SelectListItem> Sources { get; set; }
        
        public List<LanguageInfo> Languages { get; set; }

        public string BaseLanguageName { get; set; }

        public string TargetValueFilter { get; set; }
        
        public string FilterText { get; set; }
    }
}