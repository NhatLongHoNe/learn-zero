using System.Collections.Generic;
using Asd.AbpZeroTemplate.Editions.Dto;
using Asd.AbpZeroTemplate.MultiTenancy.Payments;

namespace Asd.AbpZeroTemplate.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}