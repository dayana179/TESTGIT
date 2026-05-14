using System.ComponentModel.DataAnnotations;

namespace TESTGIT.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm Email is required.")]
        [Compare("Email", ErrorMessage = "Email and Confirm Email must match.")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60.")]
        public int? Age { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms.")]
        public bool AgreeTerms { get; set; }
    }
}