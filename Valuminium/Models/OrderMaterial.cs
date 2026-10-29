using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valuminium.Models
{
    /// <summary>
    /// Link table for the N:N relation between orders and materials (OrderMaterials table).
    /// The primary key is composite: (OrderId, MaterialId). A composite key cannot be declared
    /// with attributes alone, so it will be configured later in the data access layer.
    /// </summary>
    [Table("OrderMaterials")]
    public class OrderMaterial
    {
        [Required(ErrorMessage = "Order is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid order number.")]
        [Display(Name = "Order number")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Material is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid material ID.")]
        [Display(Name = "Material")]
        public int MaterialId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        [Display(Name = "Quantity")]
        public double Quantity { get; set; }

        [Required(ErrorMessage = "Ordered status is required.")]
        [EnumDataType(typeof(OrderedStatus), ErrorMessage = "Invalid ordered status.")]
        [Display(Name = "Ordered status")]
        public OrderedStatus OrderedStatus { get; set; } = OrderedStatus.NotOrdered;

        // Navigation
        [ForeignKey(nameof(OrderId))]
        public virtual Order? Order { get; set; }

        [ForeignKey(nameof(MaterialId))]
        public virtual Material? Material { get; set; }
    }
}
