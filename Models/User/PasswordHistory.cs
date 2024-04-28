using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class PasswordHistory
    {
        [Key]
        public Guid PasswordID { get; set; }
        [MaxLength(30)]
        public string OldPassword { get; set; }
        [MaxLength(30)]
        public string NewPassword { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }
        public User User { get; set; }
        //public Guid UserID { get; set; }
    }
}
