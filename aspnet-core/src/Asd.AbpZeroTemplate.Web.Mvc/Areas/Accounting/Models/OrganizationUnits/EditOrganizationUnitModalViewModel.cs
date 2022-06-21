using Abp.AutoMapper;
using Abp.Organizations;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}