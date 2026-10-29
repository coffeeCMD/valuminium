namespace ValuminiumDTO
{
    /// <summary>A client as sent over the API.</summary>
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? Address { get; set; }
    }
}
