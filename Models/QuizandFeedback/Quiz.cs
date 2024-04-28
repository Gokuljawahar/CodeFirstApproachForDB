// namespace LMS
// {
//     // public class Quiz
//     // {
//     //     public Guid QuizId { get; set; }
//     //     public Course Course { get; set; }
//     //     public string NameOfQuiz { get; set; }
//     //     public int Duration { get; set; }
//     //     public int PassMark { get; set; }
//     //     public ICollection<QuizQuestion> QuizQuestions { get; set; }
//     //     public ICollection<UserAttempt> UserAttempts { get; set; }
//     // }
//      public class Quiz
//     {
//         public Guid QuizId { get; set; }
//         public virtual Course Course { get; set; }
//         public string NameOfQuiz { get; set; }
//         public int Duration { get; set; }
//         public int PassMark { get; set; }
//         public virtual ICollection<QuizQuestion> QuizQuestions { get; set; } = new HashSet<QuizQuestion>();
//         public virtual ICollection<UserAttempt> UserAttempts { get; set; } = new HashSet<UserAttempt>();
//     }
// }


namespace LMS{
    public class Quiz
    {
        public Guid QuizId { get; set; }
        public virtual Course Course { get; set; }
        public string NameOfQuiz { get; set; }
        public int Duration { get; set; }
        public int PassMark { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; } = new HashSet<QuizQuestion>();
        public virtual ICollection<UserAttempt> UserAttempts { get; set; } = new HashSet<UserAttempt>();
    }
}