using System.ComponentModel.DataAnnotations;

namespace Skeleton.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get;set;}
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "The password muist be between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}