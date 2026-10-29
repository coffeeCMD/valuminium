namespace ValuminiumDTO
{
    /// <summary>A supplier as sent over the API.</summary>
    public class SupplierDTO
    {
        public int SupplierId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Phone { get; set; }
    }
}
