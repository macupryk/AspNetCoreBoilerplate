using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBoilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}