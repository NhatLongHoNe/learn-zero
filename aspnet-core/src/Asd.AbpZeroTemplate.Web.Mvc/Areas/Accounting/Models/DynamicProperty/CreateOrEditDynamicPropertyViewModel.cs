using System.Collections.Generic;
using Asd.AbpZeroTemplate.DynamicEntityProperties.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
