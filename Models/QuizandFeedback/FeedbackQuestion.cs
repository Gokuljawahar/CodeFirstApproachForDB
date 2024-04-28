namespace LMS
{
   public enum QuestionType
    {
        MCQ,
        Descriptive
    }

    public class FeedbackQuestion
    {
        public int FeedbackQuestionId { get; set; }
        public int CourseId { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }

        // Navigation properties
        public virtual ICollection<FeedbackQuestionOption> Options { get; set; } = new HashSet<FeedbackQuestionOption>();
        public virtual ICollection<FeedbackResponse> Responses { get; set; } = new HashSet<FeedbackResponse>();
    }
}
