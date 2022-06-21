using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Users.Dto;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}