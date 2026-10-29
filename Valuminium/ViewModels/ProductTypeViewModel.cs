using System.ComponentModel.DataAnnotations;

namespace Valuminium.ViewModels
{
    /// <summary>View model for a product type (website catalog / management).</summary>
    public class ProductTypeViewModel
    {
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Product type name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Description is too long (max 500 characters).")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string? Description { get; set; }
    }
}
