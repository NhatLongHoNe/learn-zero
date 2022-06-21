using System;
using Abp.AutoMapper;
using Asd.AbpZeroTemplate.Sessions.Dto;

namespace Asd.AbpZeroTemplate.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}