using Abp.Dependency;
using Asd.AbpZeroTemplate.Configuration;
using Asd.AbpZeroTemplate.Url;
using Asd.AbpZeroTemplate.Web.Url;

namespace Asd.AbpZeroTemplate.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}