using System.Threading.Tasks;
using Abp.Application.Services;
using Asd.AbpZeroTemplate.Sessions.Dto;

namespace Asd.AbpZeroTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
