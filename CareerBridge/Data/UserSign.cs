using System.ComponentModel.DataAnnotations;

namespace CareerBridge.Data
{
    public class UserSign
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public int PIN { get; set; }
        public string VerificationCode { get; set; } = string.Empty;
        public bool IsVerified { get; set; } = false;
    }
}
