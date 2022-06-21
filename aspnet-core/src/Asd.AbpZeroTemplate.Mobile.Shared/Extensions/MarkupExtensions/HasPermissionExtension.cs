using System;
using Asd.AbpZeroTemplate.Core;
using Asd.AbpZeroTemplate.Core.Dependency;
using Asd.AbpZeroTemplate.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asd.AbpZeroTemplate.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}