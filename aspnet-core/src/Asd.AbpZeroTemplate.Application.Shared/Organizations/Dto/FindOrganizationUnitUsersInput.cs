using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
