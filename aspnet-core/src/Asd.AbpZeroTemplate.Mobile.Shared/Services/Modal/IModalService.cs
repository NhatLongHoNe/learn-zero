using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Views;
using Xamarin.Forms;

namespace Asd.AbpZeroTemplate.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
