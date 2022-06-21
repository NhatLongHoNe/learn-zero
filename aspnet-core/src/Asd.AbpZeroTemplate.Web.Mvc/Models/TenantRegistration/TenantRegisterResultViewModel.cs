using Abp.AutoMapper;
using Asd.AbpZeroTemplate.MultiTenancy.Dto;

namespace Asd.AbpZeroTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}