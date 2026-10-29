using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valuminium.Models
{
    /// <summary>A customer (Clients table).</summary>
    [Table("Clients")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Client ID")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(\+972-?|0)\d{1,2}-?\d{7}$", ErrorMessage = "Invalid phone number.")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Address is too long (max 200 characters).")]
        [Display(Name = "Address")]
        public string? Address { get; set; }

        // Navigation: orders placed by this client (1:N)
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
