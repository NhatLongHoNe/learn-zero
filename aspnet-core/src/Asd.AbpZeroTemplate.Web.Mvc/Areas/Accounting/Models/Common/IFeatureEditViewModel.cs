using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.Editions.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}