using Asd.AbpZeroTemplate.MultiTenancy.Payments;

namespace Asd.AbpZeroTemplate.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}