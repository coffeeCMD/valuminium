using Valuminium.Models;

namespace ValuminiumDTO
{
    /// <summary>A user as sent over the API. Never contains the password hash.</summary>
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public UserRole Role { get; set; }
    }
}
