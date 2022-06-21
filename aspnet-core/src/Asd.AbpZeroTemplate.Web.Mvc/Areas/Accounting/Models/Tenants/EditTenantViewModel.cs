using System.Collections.Generic;
using Asd.AbpZeroTemplate.Editions.Dto;
using Asd.AbpZeroTemplate.MultiTenancy.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}