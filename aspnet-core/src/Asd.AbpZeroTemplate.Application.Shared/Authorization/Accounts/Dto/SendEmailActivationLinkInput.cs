using System.ComponentModel.DataAnnotations;

namespace Asd.AbpZeroTemplate.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}