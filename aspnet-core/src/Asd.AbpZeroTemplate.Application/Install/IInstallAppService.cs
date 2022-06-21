using System.Threading.Tasks;
using Abp.Application.Services;
using Asd.AbpZeroTemplate.Install.Dto;

namespace Asd.AbpZeroTemplate.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}