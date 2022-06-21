using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Organizations.Dto;

namespace Asd.AbpZeroTemplate.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}