using System.ComponentModel.DataAnnotations;
using Valuminium.Models;

namespace Valuminium.ViewModels
{
    /// <summary>View model for a payment. Financial data - manager only.</summary>
    public class PaymentViewModel
    {
        public int PaymentId { get; set; }

        [Required(ErrorMessage = "Order is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid order number.")]
        [Display(Name = "Order number")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Payment date")]
        public DateTime PaymentDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Payment type is required.")]
        [EnumDataType(typeof(PaymentType))]
        [Display(Name = "Payment type")]
        public PaymentType PaymentType { get; set; }
    }
}
