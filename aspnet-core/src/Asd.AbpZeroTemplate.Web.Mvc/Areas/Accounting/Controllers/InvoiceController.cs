using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.MultiTenancy.Accounting;
using Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Accounting;
using Asd.AbpZeroTemplate.Web.Controllers;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    public class InvoiceController : AbpZeroTemplateControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}