using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Material
    {
        [Key]
        public Guid MaterialID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Filepath { get; set; }
        [Required]
        public decimal Duration { get; set; }
        [Required]
        [MaxLength(15)]
        public string Type { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
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

        public Topic Topic { get; set; }

        public Course Course { get; set; }


        public ICollection<UserProgress> users { get; set; }
    }
}
