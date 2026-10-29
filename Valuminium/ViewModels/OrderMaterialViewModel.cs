using System.ComponentModel.DataAnnotations;
using Valuminium.Models;

namespace Valuminium.ViewModels
{
    /// <summary>View model for a material line inside an order.</summary>
    public class OrderMaterialViewModel
    {
        [Required(ErrorMessage = "Order is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid order number.")]
        [Display(Name = "Order number")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Material is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid material ID.")]
        [Display(Name = "Material")]
        public int MaterialId { get; set; }

        /// <summary>Display only.</summary>
        [Display(Name = "Material name")]
        public string? MaterialName { get; set; }

        /// <summary>Display only.</summary>
        [Display(Name = "Unit")]
        public string? Unit { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        [Display(Name = "Quantity")]
        public double Quantity { get; set; }

        [Required(ErrorMessage = "Ordered status is required.")]
        [EnumDataType(typeof(OrderedStatus))]
        [Display(Name = "Ordered status")]
        public OrderedStatus OrderedStatus { get; set; } = OrderedStatus.NotOrdered;
    }
}
