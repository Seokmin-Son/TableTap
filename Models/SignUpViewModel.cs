using System.ComponentModel.DataAnnotations;

namespace TableTap.Models
{
    public class SignUpViewModel
    {
        [Required]
        public string Username { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = "";
    }
}
