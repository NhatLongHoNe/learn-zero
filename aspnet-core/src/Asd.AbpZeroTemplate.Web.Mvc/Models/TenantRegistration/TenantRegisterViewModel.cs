using Asd.AbpZeroTemplate.Editions;
using Asd.AbpZeroTemplate.Editions.Dto;
using Asd.AbpZeroTemplate.MultiTenancy.Payments;
using Asd.AbpZeroTemplate.Security;
using Asd.AbpZeroTemplate.MultiTenancy.Payments.Dto;

namespace Asd.AbpZeroTemplate.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
