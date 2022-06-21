using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Editions.Dto;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}