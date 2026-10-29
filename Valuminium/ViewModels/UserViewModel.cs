using System.ComponentModel.DataAnnotations;
using Valuminium.Models;

namespace Valuminium.ViewModels
{
    /// <summary>
    /// View model for a user. It never exposes PasswordHash; a raw password is accepted
    /// only when creating a user or changing a password.
    /// </summary>
    public class UserViewModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters.")]
        [Display(Name = "Full name")]
        public string FullName { get; set; } = string.Empty;

        [RegularExpression(@"^(\+972-?|0)\d{1,2}-?\d{7}$", ErrorMessage = "Invalid phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Role is required.")]
        [EnumDataType(typeof(UserRole))]
        [Display(Name = "Role")]
        public UserRole Role { get; set; } = UserRole.Employee;

        /// <summary>Required only when creating a user or changing a password.</summary>
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string? ConfirmPassword { get; set; }
    }
}
