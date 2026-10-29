using Valuminium.Models;

namespace ValuminiumDTO
{
    /// <summary>A payment as sent over the API. Manager only.</summary>
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
