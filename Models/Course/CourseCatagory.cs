using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class CourseCatagory
    {
        [Key]
        public Guid CatagoryID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Category { get; set; }
        [Required]
        [MaxLength(120)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        [MaxLength(120)]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        // One to many
        public ICollection<Course> Course { get; set; }
    }
}
