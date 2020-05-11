using System.ComponentModel.DataAnnotations;

namespace Ogulcan.BookStore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}