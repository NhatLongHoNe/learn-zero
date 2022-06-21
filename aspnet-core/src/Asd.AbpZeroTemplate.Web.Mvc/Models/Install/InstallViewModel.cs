using System.Collections.Generic;
using Abp.Localization;
using Asd.AbpZeroTemplate.Install.Dto;

namespace Asd.AbpZeroTemplate.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
