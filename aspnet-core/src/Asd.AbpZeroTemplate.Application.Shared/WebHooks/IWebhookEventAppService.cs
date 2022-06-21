using System.Threading.Tasks;
using Abp.Webhooks;

namespace Asd.AbpZeroTemplate.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
