namespace ValuminiumDTO
{
    /// <summary>Credentials sent by the client when signing in.</summary>
    public class LoginRequestDTO
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
