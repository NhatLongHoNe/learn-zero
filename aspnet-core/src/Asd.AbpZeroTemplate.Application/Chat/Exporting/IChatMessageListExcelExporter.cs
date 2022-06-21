using System.Collections.Generic;
using Abp;
using Asd.AbpZeroTemplate.Chat.Dto;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
