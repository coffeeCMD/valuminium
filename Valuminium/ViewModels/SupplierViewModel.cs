using System.ComponentModel.DataAnnotations;

namespace Valuminium.ViewModels
{
    /// <summary>View model for a supplier.</summary>
    public class SupplierViewModel
    {
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [RegularExpression(@"^(\+972-?|0)\d{1,2}-?\d{7}$", ErrorMessage = "Invalid phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string? Phone { get; set; }
    }
}
