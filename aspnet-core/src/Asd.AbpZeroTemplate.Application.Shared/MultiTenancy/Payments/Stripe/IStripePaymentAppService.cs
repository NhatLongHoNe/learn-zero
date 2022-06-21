using System.Threading.Tasks;
using Abp.Application.Services;
using Asd.AbpZeroTemplate.MultiTenancy.Payments.Dto;
using Asd.AbpZeroTemplate.MultiTenancy.Payments.Stripe.Dto;

namespace Asd.AbpZeroTemplate.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}