using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Sessions.Dto;

namespace Asd.AbpZeroTemplate.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
