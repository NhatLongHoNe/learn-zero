using System.Collections.Generic;
using Asd.AbpZeroTemplate.Editions;
using Asd.AbpZeroTemplate.Editions.Dto;
using Asd.AbpZeroTemplate.MultiTenancy.Payments;
using Asd.AbpZeroTemplate.MultiTenancy.Payments.Dto;

namespace Asd.AbpZeroTemplate.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
