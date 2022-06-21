using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
