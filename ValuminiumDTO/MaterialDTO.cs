using Valuminium.Models;

namespace ValuminiumDTO
{
    /// <summary>A raw material as sent over the API.</summary>
    public class MaterialDTO
    {
        public int MaterialId { get; set; }
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string Name { get; set; } = string.Empty;
        public MaterialType MaterialType { get; set; }
        public string Unit { get; set; } = "unit";
    }
}
