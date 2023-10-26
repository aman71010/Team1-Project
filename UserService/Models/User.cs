using System.ComponentModel.DataAnnotations;

namespace UserService.Models
{
    public enum Role
    {
        Customer,
        Admin
    }
    public class User
    {
        [Key]
        [Required, EmailAddress]
        public string UserEmailId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, MinLength(6, ErrorMessage = "Password required atleast 6 characters.")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a 10-digit mobile number.")]
        public long MobileNo { get; set; }
        public byte[]? UserImage { get; set; }
        public Address? Address { get; set; }
        public Role UserRole { get; set; } = Role.Customer;
    }
}
