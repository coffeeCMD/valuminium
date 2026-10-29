namespace ValuminiumDTO
{
    /// <summary>A guest's quote request sent from the website. Contains no financial fields.</summary>
    public class QuoteRequestDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? Address { get; set; }
        public int ProductTypeId { get; set; }
        public string? Description { get; set; }
        public string? Measurements { get; set; }
        public string? Color { get; set; }
    }
}
