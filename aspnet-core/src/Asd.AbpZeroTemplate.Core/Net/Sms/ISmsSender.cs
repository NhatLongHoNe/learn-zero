using System.Threading.Tasks;

namespace Asd.AbpZeroTemplate.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}