using System.Threading.Tasks;
using Abp.Application.Services;
using Asd.AbpZeroTemplate.Configuration.Tenants.Dto;

namespace Asd.AbpZeroTemplate.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
