using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Asd.AbpZeroTemplate
{
    public class AbpZeroTemplateCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateCoreSharedModule).GetAssembly());
        }
    }
}