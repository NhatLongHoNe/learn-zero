using System.Threading.Tasks;
using Abp.Application.Services;
using Asd.AbpZeroTemplate.Configuration.Host.Dto;

namespace Asd.AbpZeroTemplate.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
