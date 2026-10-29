using System.ComponentModel.DataAnnotations;
using Valuminium.Models;

namespace Valuminium.ViewModels
{
    /// <summary>View model for a raw material in the catalog.</summary>
    public class MaterialViewModel
    {
        public int MaterialId { get; set; }

        [Required(ErrorMessage = "Supplier is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid supplier.")]
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        /// <summary>Display only.</summary>
        [Display(Name = "Supplier name")]
        public string? SupplierName { get; set; }

        [Required(ErrorMessage = "Material name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Material type is required.")]
        [EnumDataType(typeof(MaterialType))]
        [Display(Name = "Material type")]
        public MaterialType MaterialType { get; set; }

        [Required(ErrorMessage = "Unit is required.")]
        [StringLength(20, ErrorMessage = "Unit is too long (max 20 characters).")]
        [Display(Name = "Unit")]
        public string Unit { get; set; } = "unit";
    }
}
