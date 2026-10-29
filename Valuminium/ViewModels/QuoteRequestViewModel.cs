using System.ComponentModel.DataAnnotations;

namespace Valuminium.ViewModels
{
    /// <summary>
    /// The "request a quote" form a guest fills in on the website.
    /// Contains client details and request details, with no financial fields.
    /// </summary>
    public class QuoteRequestViewModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(\+972-?|0)\d{1,2}-?\d{7}$", ErrorMessage = "Invalid phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Address is too long (max 200 characters).")]
        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Product type is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid product type.")]
        [Display(Name = "Product type")]
        public int ProductTypeId { get; set; }

        [StringLength(1000, ErrorMessage = "Description is too long (max 1000 characters).")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Request description")]
        public string? Description { get; set; }

        [StringLength(300, ErrorMessage = "Measurements are too long (max 300 characters).")]
        [Display(Name = "Measurements")]
        public string? Measurements { get; set; }

        [StringLength(50, ErrorMessage = "Color is too long (max 50 characters).")]
        [Display(Name = "Color")]
        public string? Color { get; set; }
    }
}
