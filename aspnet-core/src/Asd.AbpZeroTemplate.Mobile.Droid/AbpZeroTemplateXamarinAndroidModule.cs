using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Asd.AbpZeroTemplate
{
    [DependsOn(typeof(AbpZeroTemplateXamarinSharedModule))]
    public class AbpZeroTemplateXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateXamarinAndroidModule).GetAssembly());
        }
    }
}