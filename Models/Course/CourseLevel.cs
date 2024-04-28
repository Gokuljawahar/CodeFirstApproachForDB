using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class CourseLevel
    {
        [Key]
        public Guid LevelID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Level { get; set; }
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

        //One to many
        public ICollection<Course> Courses { get; set; }
    }
}
