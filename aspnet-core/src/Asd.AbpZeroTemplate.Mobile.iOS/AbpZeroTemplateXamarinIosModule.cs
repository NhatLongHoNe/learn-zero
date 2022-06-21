using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Asd.AbpZeroTemplate
{
    [DependsOn(typeof(AbpZeroTemplateXamarinSharedModule))]
    public class AbpZeroTemplateXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateXamarinIosModule).GetAssembly());
        }
    }
}