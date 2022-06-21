using Abp.AutoMapper;
using Asd.AbpZeroTemplate.MultiTenancy.Dto;

namespace Asd.AbpZeroTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
