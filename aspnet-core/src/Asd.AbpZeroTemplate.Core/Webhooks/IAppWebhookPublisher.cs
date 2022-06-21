using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Authorization.Users;

namespace Asd.AbpZeroTemplate.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
