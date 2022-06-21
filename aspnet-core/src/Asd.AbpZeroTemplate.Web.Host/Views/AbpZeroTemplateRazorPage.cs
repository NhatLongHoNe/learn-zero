using Abp.AspNetCore.Mvc.Views;

namespace Asd.AbpZeroTemplate.Web.Views
{
    public abstract class AbpZeroTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AbpZeroTemplateRazorPage()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}
