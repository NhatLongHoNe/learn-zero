using System.ComponentModel.DataAnnotations;

namespace Asd.AbpZeroTemplate.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
