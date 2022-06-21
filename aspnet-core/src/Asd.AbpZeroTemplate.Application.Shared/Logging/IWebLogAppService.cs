using Abp.Application.Services;
using Asd.AbpZeroTemplate.Dto;
using Asd.AbpZeroTemplate.Logging.Dto;

namespace Asd.AbpZeroTemplate.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
