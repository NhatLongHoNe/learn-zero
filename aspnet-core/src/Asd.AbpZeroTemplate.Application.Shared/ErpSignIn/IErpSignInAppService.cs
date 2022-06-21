using Abp.Application.Services;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using Asd.AbpZeroTemplate.ErpSignIn.Dto;
using System.Net.Http;

namespace Asd.AbpZeroTemplate.ErpSignIn
{
    public interface IErpSignInAppService : IApplicationService
    {
        Task<ErpCurrentUserDto> SignInUser(string token, string code);        
    }
}
