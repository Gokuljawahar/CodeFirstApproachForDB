// namespace LMS
// {
//     // public class QuizQuestion
//     // {
//     //     public Guid QuizQuestionId { get; set; }
//     //     public Quiz Quiz { get; set; }
//     //     public int QuestionNo { get; set; }
//     //     public string Question { get; set; }
       
//     //     public ICollection<QuestionOption> QuestionOptions { get; set; }
//     //     public ICollection<UserAnswer> UserAnswers { get; set; }
//     // }
//     public class QuizQuestion
//     {
//         public Guid QuizQuestionId { get; set; }
//         public virtual Quiz Quiz { get; set; }
//         public int QuestionNo { get; set; }
//         public string Question { get; set; }
//         public virtual ICollection<QuestionOption> QuestionOptions { get; set; } = new HashSet<QuestionOption>();
//         public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
//     }
// }

 namespace LMS{
     public class QuizQuestion
    {
        public Guid QuizQuestionId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; } = new HashSet<QuestionOption>();
        public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
    }

 }
