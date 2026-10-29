namespace ValuminiumDTO
{
    /// <summary>
    /// An order WITH financial data. Sent to the manager only.
    /// </summary>
    public class ManagerOrderDTO : OrderDTO
    {
        /// <summary>Null until the manager prices the request.</summary>
        public double? Price { get; set; }
        public double TotalPaid { get; set; }

        /// <summary>Price minus TotalPaid; null while the order has no price.</summary>
        public double? Balance { get; set; }
    }
}
