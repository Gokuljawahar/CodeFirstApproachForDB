﻿using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class UserProgress
    {
        [Key]
        public Guid UserProgressID { get; set; }
        //[Required]
        //public string UserID { get; set; }

        [Required]
        public TimeOnly WatchTime { get; set; }
        [Required]
        public TimeOnly TotalTime { get; set; }
        [Required]
        public bool IsWatched { get; set; }

        public Course Course { get; set; }

        public Topic Topic { get; set; }

        public Material Material { get; set; }
        public User User { get; set; }
    }
    
}
