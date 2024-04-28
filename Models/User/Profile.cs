using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Profile
    {
        [Key]
        public Guid ProfileID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateOnly DOB { get; set; }
        [Required]
        [MaxLength(20)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(15)]
        public string ContactNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Stream { get; set; }
        //modified
        public User User { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }
        //public User User { get; set; }
    }
}
