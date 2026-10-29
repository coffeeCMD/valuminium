using System.ComponentModel.DataAnnotations;
using Valuminium.Models;

namespace Valuminium.ViewModels
{
    /// <summary>
    /// View model for an order.
    /// Price is financial data: it should be filled in and shown only to the manager
    /// (to be enforced in the API layer).
    /// </summary>
    public class OrderViewModel
    {
        [Display(Name = "Order number")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Client is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid client.")]
        [Display(Name = "Client")]
        public int ClientId { get; set; }

        /// <summary>Display only.</summary>
        [Display(Name = "Client name")]
        public string? ClientName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Invalid user ID.")]
        [Display(Name = "Handled by")]
        public int? HandledByUserId { get; set; }

        /// <summary>Display only.</summary>
        [Display(Name = "Handler name")]
        public string? HandledByUserName { get; set; }

        [Required(ErrorMessage = "Product type is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid product type.")]
        [Display(Name = "Product type")]
        public int ProductTypeId { get; set; }

        /// <summary>Display only.</summary>
        [Display(Name = "Product type name")]
        public string? ProductTypeName { get; set; }

        [StringLength(1000, ErrorMessage = "Description is too long (max 1000 characters).")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [StringLength(300, ErrorMessage = "Measurements are too long (max 300 characters).")]
        [Display(Name = "Measurements")]
        public string? Measurements { get; set; }

        [StringLength(50, ErrorMessage = "Color is too long (max 50 characters).")]
        [Display(Name = "Color")]
        public string? Color { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Order date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Order date")]
        public DateTime OrderDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Status is required.")]
        [EnumDataType(typeof(OrderStatus))]
        [Display(Name = "Status")]
        public OrderStatus Status { get; set; } = OrderStatus.QuoteRequest;
    }
}
