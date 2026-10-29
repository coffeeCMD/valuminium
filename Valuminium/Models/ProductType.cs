using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valuminium.Models
{
    /// <summary>A product type (ProductTypes table). Name must be unique.</summary>
    [Table("ProductTypes")]
    public class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Product type ID")]
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Product type name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Description is too long (max 500 characters).")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        // Navigation: orders of this product type (1:N)
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
