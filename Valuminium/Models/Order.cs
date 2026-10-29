using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valuminium.Models
{
    /// <summary>An order / quote request (Orders table).</summary>
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Order number")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Client is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid client.")]
        [Display(Name = "Client")]
        public int ClientId { get; set; }

        /// <summary>NULL until an employee or manager takes the order.</summary>
        [Range(1, int.MaxValue, ErrorMessage = "Invalid user ID.")]
        [Display(Name = "Handled by")]
        public int? HandledByUserId { get; set; }

        [Required(ErrorMessage = "Product type is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid product type.")]
        [Display(Name = "Product type")]
        public int ProductTypeId { get; set; }

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

        /// <summary>NULL until the manager prices the request. Financial data - manager only.</summary>
        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Order date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Order date")]
        public DateTime OrderDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Status is required.")]
        [EnumDataType(typeof(OrderStatus), ErrorMessage = "Invalid status.")]
        [Display(Name = "Status")]
        public OrderStatus Status { get; set; } = OrderStatus.QuoteRequest;

        // Navigation
        [ForeignKey(nameof(ClientId))]
        public virtual Client? Client { get; set; }

        [ForeignKey(nameof(HandledByUserId))]
        public virtual User? HandledByUser { get; set; }

        [ForeignKey(nameof(ProductTypeId))]
        public virtual ProductType? ProductType { get; set; }

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual ICollection<OrderMaterial> OrderMaterials { get; set; } = new List<OrderMaterial>();
    }
}
