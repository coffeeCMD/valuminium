namespace ValuminiumDTO
{
    /// <summary>A product type as sent over the API.</summary>
    public class ProductTypeDTO
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
