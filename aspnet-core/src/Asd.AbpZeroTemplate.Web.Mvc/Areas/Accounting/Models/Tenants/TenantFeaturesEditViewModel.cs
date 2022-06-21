using Abp.AutoMapper;
using Asd.AbpZeroTemplate.MultiTenancy;
using Asd.AbpZeroTemplate.MultiTenancy.Dto;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}