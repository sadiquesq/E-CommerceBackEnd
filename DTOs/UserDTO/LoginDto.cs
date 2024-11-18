using System.ComponentModel.DataAnnotations;

namespace E_Commerce.DTOs
{
    public class LoginDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
