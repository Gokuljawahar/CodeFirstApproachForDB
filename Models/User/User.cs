using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        [MaxLength(10)]
        public string Role { get; set; }
        public bool UnblockRequest { get; set; }
        public bool AccountStatus { get; set; }
        public DateTime UserLastLogin { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }
        //public Profile Profile { get; set; }
        //public Enrollment Enrollment { get; set; }
        //public PasswordHistory PasswordHistory { get; set; }
    }
}
