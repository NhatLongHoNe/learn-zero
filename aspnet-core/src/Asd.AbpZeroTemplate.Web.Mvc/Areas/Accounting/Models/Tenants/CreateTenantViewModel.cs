using System.Collections.Generic;
using Asd.AbpZeroTemplate.Editions.Dto;
using Asd.AbpZeroTemplate.Security;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public CreateTenantViewModel(IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}