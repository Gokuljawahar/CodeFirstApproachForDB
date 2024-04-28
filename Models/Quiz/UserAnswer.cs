// namespace LMS
// {
//     // public class UserAnswer
//     // {
//     //     public Guid UserAnswerId { get; set; }
//     //     public UserAttempt UserAttempt { get; set; }
//     //     public QuizQuestion QuizQuestion { get; set; }
//     //     public QuestionOption QuestionOption { get; set; }
        
//     // }
//     public class UserAnswer
//     {
//         public Guid UserAnswerId { get; set; }
//         public virtual UserAttempt UserAttempt { get; set; }
//         public virtual QuizQuestion QuizQuestion { get; set; }
//         public virtual QuestionOption QuestionOption { get; set; }
//     }

// }

namespace LMS{
    public class UserAnswer
    {
        public Guid UserAnswerId { get; set; }
        public virtual UserAttempt UserAttempt { get; set; }
        public virtual QuizQuestion QuizQuestion { get; set; }
        public virtual QuestionOption QuestionOption { get; set; }
    }
}