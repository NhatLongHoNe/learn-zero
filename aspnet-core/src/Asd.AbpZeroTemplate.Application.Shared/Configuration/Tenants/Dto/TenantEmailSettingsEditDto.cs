using Abp.Auditing;
using Asd.AbpZeroTemplate.Configuration.Dto;

namespace Asd.AbpZeroTemplate.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}