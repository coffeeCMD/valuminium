using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valuminium.Models
{
    /// <summary>A raw material in the catalog (Materials table).</summary>
    [Table("Materials")]
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Material ID")]
        public int MaterialId { get; set; }

        [Required(ErrorMessage = "Supplier is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid supplier.")]
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Material name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Material type is required.")]
        [EnumDataType(typeof(MaterialType), ErrorMessage = "Invalid material type.")]
        [Display(Name = "Material type")]
        public MaterialType MaterialType { get; set; }

        [Required(ErrorMessage = "Unit is required.")]
        [StringLength(20, ErrorMessage = "Unit is too long (max 20 characters).")]
        [Display(Name = "Unit")]
        public string Unit { get; set; } = "unit";

        // Navigation
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier? Supplier { get; set; }

        public virtual ICollection<OrderMaterial> OrderMaterials { get; set; } = new List<OrderMaterial>();
    }
}
