namespace ValuminiumDTO
{
    /// <summary>One row of the debt list (matches the v_OrderBalance view). Manager only.</summary>
    public class OrderBalanceDTO
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public double Price { get; set; }
        public double TotalPaid { get; set; }
        public double Balance { get; set; }
    }
}
