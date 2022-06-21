using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Users.Importing.Dto;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
