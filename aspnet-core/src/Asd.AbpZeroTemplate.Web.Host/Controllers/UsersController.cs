using Abp.AspNetCore.Mvc.Authorization;
using Asd.AbpZeroTemplate.Authorization;
using Asd.AbpZeroTemplate.Storage;
using Abp.BackgroundJobs;

namespace Asd.AbpZeroTemplate.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}