using System.Collections.Generic;
using Asd.AbpZeroTemplate.Editions.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}