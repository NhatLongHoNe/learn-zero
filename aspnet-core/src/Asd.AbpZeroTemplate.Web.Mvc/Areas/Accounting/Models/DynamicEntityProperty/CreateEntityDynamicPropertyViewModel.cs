using System.Collections.Generic;
using Asd.AbpZeroTemplate.DynamicEntityProperties.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
