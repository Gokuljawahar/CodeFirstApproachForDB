using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Topic
    {
        [Key]
        public Guid TopicID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
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


        public Course Course { get; set; }

        public ICollection<Material> Materials { get; set; }

        public ICollection<UserProgress> UsersProgress { get; set; }
    }
}
