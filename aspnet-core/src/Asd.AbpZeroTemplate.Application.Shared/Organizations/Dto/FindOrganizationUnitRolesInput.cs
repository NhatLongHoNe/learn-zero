using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}