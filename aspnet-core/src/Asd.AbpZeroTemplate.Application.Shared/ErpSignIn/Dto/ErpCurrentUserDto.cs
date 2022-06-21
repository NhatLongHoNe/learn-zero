using System;
using System.Collections.Generic;
using System.Text;

namespace Asd.AbpZeroTemplate.ErpSignIn.Dto
{
    public class GetUserExternalresult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErpCurrentUserDto Data { get; set; }
    }

    public class ErpCurrentUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string OneTimePassword { get; set; }
    }
}
