﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.DTOs
{
    public class LoginDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = "Password must contain at least one letter, one number, and one special character.")]
        public string Password { get; set; }
    }
}
