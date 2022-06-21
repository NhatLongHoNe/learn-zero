using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Asd.AbpZeroTemplate.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
