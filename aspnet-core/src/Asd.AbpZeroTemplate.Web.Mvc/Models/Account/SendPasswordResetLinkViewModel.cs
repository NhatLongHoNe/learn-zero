﻿using System.ComponentModel.DataAnnotations;

namespace Asd.AbpZeroTemplate.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}