using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Security.Recaptcha;

namespace Asd.AbpZeroTemplate.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
