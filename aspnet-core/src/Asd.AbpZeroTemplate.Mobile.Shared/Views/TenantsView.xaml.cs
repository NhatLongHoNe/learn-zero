using Asd.AbpZeroTemplate.Models.Tenants;
using Asd.AbpZeroTemplate.ViewModels;
using Xamarin.Forms;

namespace Asd.AbpZeroTemplate.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}