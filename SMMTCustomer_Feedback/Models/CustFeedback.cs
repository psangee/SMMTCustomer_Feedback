using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMMTCustomer_Feedback.Models
{
    public class CustFeedback
    {
        [Key]
        public int FeedbackID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string FeedbackMessage { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateSubmitted { get; set; }

    }
}
