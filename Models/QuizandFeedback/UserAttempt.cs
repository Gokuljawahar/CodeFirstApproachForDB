// namespace LMS
// {
//     // public class UserAttempt
//     // {
//     //     public Guid UserAttemptId { get; set; }
       
//     //     public User User { get; set; }
//     //     public Quiz Quiz { get; set; }
//     //     public int AttemptCount { get; set; }
//     //     public DateTime StartTime { get; set; }
//     //     public DateTime EndTime { get; set; }
//     //     public float Score { get; set; }
        
//     //     public ICollection<UserAnswer> UserAnswers { get; set; }
//     // }
//     public class UserAttempt
//     {
//         public Guid UserAttemptId { get; set; }
//         public virtual User User { get; set; }
//         public virtual Quiz Quiz { get; set; }
//         public int AttemptCount { get; set; }
//         public DateTime StartTime { get; set; }
//         public DateTime EndTime { get; set; }
//         public float Score { get; set; }
//         public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
//     }
// }

namespace LMS{
    public class UserAttempt
    {
        public Guid UserAttemptId { get; set; }
        public virtual User User { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int AttemptCount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public float Score { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
    }
}