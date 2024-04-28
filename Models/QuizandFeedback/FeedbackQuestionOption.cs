using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class FeedbackQuestionOption
    {
        [Key]
        public int OptionId { get; set; }
        public int FeedbackQuestionId { get; set; }
        public string OptionText { get; set; }

        // Navigation properties
        public virtual FeedbackQuestion FeedbackQuestion { get; set; }
        public virtual ICollection<FeedbackResponse> Responses { get; set; } = new HashSet<FeedbackResponse>();
    }


}
