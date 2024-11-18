using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class User
    {

        public Guid UserId { get; set; }


        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public bool IsBlock { get; set; } = true;

        public string Role { get; set; } = "User";

        
        public DateTime CreatedDate { get; set; }= DateTime.Now;


        public virtual Cart Cart { get; set; }

        public virtual ICollection<WhishList> WhishLists { get; set; }


    }
}
