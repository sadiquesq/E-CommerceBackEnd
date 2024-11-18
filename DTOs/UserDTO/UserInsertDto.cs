using System.ComponentModel.DataAnnotations;

namespace E_Commerce.DTOs.UserDTO
{
    public class UserInsertDto
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
