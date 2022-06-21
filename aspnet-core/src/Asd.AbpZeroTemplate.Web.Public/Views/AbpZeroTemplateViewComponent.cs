using Abp.AspNetCore.Mvc.ViewComponents;

namespace Asd.AbpZeroTemplate.Web.Public.Views
{
    public abstract class AbpZeroTemplateViewComponent : AbpViewComponent
    {
        protected AbpZeroTemplateViewComponent()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}