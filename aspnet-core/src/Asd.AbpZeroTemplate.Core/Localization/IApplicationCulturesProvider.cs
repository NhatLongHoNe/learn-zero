using System.Globalization;

namespace Asd.AbpZeroTemplate.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}