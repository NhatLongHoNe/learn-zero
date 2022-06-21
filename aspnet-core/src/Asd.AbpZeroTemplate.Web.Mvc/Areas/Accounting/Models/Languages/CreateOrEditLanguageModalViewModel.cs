using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Localization.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}