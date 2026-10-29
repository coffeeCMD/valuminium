using Valuminium.Models;

namespace ValuminiumDTO
{
    /// <summary>
    /// An order WITHOUT any financial data. This is the only order shape employees receive.
    /// </summary>
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string? ClientName { get; set; }
        public int? HandledByUserId { get; set; }
        public string? HandledByUserName { get; set; }
        public int ProductTypeId { get; set; }
        public string? ProductTypeName { get; set; }
        public string? Description { get; set; }
        public string? Measurements { get; set; }
        public string? Color { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
    }
}
