using System.Threading.Tasks;
using Abp.Application.Services;
using Asd.AbpZeroTemplate.MultiTenancy.Payments.PayPal.Dto;

namespace Asd.AbpZeroTemplate.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
