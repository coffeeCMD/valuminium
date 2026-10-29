using Valuminium.Models;

namespace ValuminiumDTO
{
    /// <summary>A material line inside an order, as sent over the API.</summary>
    public class OrderMaterialDTO
    {
        public int OrderId { get; set; }
        public int MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public string? Unit { get; set; }
        public double Quantity { get; set; }
        public OrderedStatus OrderedStatus { get; set; }
    }
}
