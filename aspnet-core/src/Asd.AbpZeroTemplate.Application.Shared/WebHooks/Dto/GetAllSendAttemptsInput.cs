using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
