using System.ComponentModel.DataAnnotations;

namespace DevExpViewer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}