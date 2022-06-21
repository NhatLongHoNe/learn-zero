using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.Configuration.Host.Dto;
using Asd.AbpZeroTemplate.Editions.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}