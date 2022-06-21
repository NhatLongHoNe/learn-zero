using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.WebHooks.Dto;

namespace Asd.AbpZeroTemplate.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
