using Microsoft.Extensions.Configuration;

namespace Asd.AbpZeroTemplate.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
