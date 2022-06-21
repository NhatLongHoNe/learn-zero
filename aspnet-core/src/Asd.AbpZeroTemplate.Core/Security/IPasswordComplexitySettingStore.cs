using System.Threading.Tasks;

namespace Asd.AbpZeroTemplate.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
