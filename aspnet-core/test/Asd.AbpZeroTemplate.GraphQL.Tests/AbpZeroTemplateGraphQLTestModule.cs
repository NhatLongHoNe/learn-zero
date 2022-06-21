using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Asd.AbpZeroTemplate.Configure;
using Asd.AbpZeroTemplate.Startup;
using Asd.AbpZeroTemplate.Test.Base;

namespace Asd.AbpZeroTemplate.GraphQL.Tests
{
    [DependsOn(
        typeof(AbpZeroTemplateGraphQLModule),
        typeof(AbpZeroTemplateTestBaseModule))]
    public class AbpZeroTemplateGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateGraphQLTestModule).GetAssembly());
        }
    }
}