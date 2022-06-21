using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.Authorization.Users.Dto;

namespace Asd.AbpZeroTemplate.Authorization.Users
{
    public interface IUserLinkAppService : IApplicationService
    {
        Task LinkToUser(LinkToUserInput linkToUserInput);

        Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input);

        Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers();

        Task UnlinkUser(UnlinkUserInput input);
    }
}
