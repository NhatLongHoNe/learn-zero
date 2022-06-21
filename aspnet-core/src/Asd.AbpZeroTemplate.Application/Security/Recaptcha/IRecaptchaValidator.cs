using System.Threading.Tasks;

namespace Asd.AbpZeroTemplate.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}