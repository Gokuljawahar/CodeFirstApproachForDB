namespace LMS
{
   public class FeedbackResponse
    {
        public int FeedbackResponseId { get; set; }
        public int FeedbackQuestionId { get; set; }
        public int UserId { get; set; }
        public string Response { get; set; } // This will hold the answer for descriptive type questions
        public int? OptionId { get; set; } // This will hold the selected option for MCQ type questions

        // Navigation properties
        public virtual FeedbackQuestion FeedbackQuestion { get; set; }
        public virtual FeedbackQuestionOption SelectedOption { get; set; }
    }
}
