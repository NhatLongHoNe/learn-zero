using System.Collections.Generic;
using System.Linq;
using Asd.AbpZeroTemplate.Configuration.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.UiCustomization
{
    public class UiCustomizationViewModel
    {
        public string Theme { get; set; }

        public List<ThemeSettingsDto> Settings { get; set; }

        public bool HasUiCustomizationPagePermission { get; set; }

        public ThemeSettingsDto GetThemeSettings(string themeName)
        {
            return Settings.First(s => s.Theme == themeName);
        }
    }
}
