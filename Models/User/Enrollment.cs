using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Enrollment
    {
        public Guid EnrollmentID { get; set; }
        //user id navigated
        public User User { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool EnrollStatus { get; set; }
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
