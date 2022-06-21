using System.Collections.Generic;
using Asd.AbpZeroTemplate.Authorization.Users.Dto;

namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}