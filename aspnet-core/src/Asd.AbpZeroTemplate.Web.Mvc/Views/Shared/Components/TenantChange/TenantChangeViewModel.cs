using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Sessions.Dto;

namespace Asd.AbpZeroTemplate.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}