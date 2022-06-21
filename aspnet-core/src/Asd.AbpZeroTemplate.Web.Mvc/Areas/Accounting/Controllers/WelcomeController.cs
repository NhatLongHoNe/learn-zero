using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Web.Controllers;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}