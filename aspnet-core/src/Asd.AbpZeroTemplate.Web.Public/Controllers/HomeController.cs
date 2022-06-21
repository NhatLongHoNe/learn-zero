using Microsoft.AspNetCore.Mvc;
using Asd.AbpZeroTemplate.Web.Controllers;

namespace Asd.AbpZeroTemplate.Web.Public.Controllers
{
    public class HomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}