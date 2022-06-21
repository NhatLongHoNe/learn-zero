using System.Collections.Generic;

namespace Asd.AbpZeroTemplate.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
