using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Auditing;
using Asd.AbpZeroTemplate.Auditing.Dto;
using Asd.AbpZeroTemplate.Authorization;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.AuditLogs;
using Asd.AbpZeroTemplate.Web.Controllers;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroTemplateControllerBase
    {
        private readonly IAuditLogAppService _auditLogAppService;

        public AuditLogsController(IAuditLogAppService auditLogAppService)
        {
            _auditLogAppService = auditLogAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> EntityChangeDetailModal(EntityChangeListDto entityChangeListDto)
        {
            var output = await _auditLogAppService.GetEntityPropertyChanges(entityChangeListDto.Id);

            var viewModel = new EntityChangeDetailModalViewModel(output, entityChangeListDto);

            return PartialView("_EntityChangeDetailModal", viewModel);
        }
    }
}