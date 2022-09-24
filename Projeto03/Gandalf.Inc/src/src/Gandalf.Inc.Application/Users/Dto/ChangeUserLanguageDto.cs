using System.ComponentModel.DataAnnotations;

namespace Gandalf.Inc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}