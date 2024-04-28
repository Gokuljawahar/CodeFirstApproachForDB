// namespace LMS
// {
//     // public class QuestionOption
//     // {
//     //     public Guid QuestionOptionId { get; set; }
        
//     //     public string Option { get; set; }
//     //     public bool IsCorrect { get; set; }
//     //     public QuizQuestion QuizQuestion { get; set; }
//     //     public ICollection<UserAnswer> UserAnswers { get; set; }
//     // }
//     public class QuestionOption
//     {
//         public Guid QuestionOptionId { get; set; }
//         public string Option { get; set; }
//         public bool IsCorrect { get; set; }
//         public virtual QuizQuestion QuizQuestion { get; set; }
//         public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
//     }
// }
namespace LMS
{
    public class QuestionOption
    {
        public Guid QuestionOptionId { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }
        public virtual QuizQuestion QuizQuestion { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
    }
}