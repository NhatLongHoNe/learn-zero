using System.Collections.Generic;
using Asd.AbpZeroTemplate.Auditing.Dto;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
