using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Asd.AbpZeroTemplate.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
