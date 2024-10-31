using System.ComponentModel.DataAnnotations;
using TaskerAPI.Models.Enums;

namespace TaskerAPI.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        // public Roles Role { get; set; } = Roles.User;
    }

    public class LoginDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
} 