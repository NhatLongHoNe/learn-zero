using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Asd.AbpZeroTemplate.WebHooks.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
