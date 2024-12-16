using System.ComponentModel.DataAnnotations;

namespace E_commerce_Website.Models
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }
        public int user_name { get; set; }
        public int user_message { get; set; }
    }
}
