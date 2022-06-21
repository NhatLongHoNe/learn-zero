using System.Collections.Generic;
using MvvmHelpers;
using Asd.AbpZeroTemplate.Models.NavigationMenu;

namespace Asd.AbpZeroTemplate.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}