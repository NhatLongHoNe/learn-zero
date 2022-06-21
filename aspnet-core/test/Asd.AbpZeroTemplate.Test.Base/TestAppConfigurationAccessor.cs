using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Asd.AbpZeroTemplate.Configuration;

namespace Asd.AbpZeroTemplate.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(AbpZeroTemplateTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
