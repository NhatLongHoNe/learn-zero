using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.Editions.Dto;

namespace Asd.AbpZeroTemplate.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}