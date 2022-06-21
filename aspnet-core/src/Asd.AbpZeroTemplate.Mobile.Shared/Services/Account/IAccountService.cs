using System.Threading.Tasks;
using Asd.AbpZeroTemplate.ApiClient.Models;

namespace Asd.AbpZeroTemplate.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        
        Task LoginUserAsync();

        Task LogoutAsync();
    }
}
