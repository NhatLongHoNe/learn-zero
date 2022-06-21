using System.Collections.Generic;
using Asd.AbpZeroTemplate.Organizations.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}