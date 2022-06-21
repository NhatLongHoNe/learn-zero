using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.Configuration.Tenants.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}