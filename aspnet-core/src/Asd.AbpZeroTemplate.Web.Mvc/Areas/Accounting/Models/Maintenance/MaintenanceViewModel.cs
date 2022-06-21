using System.Collections.Generic;
using Asd.AbpZeroTemplate.Caching.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}