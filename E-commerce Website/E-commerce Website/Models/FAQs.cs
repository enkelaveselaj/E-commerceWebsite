using System.ComponentModel.DataAnnotations;

namespace E_commerce_Website.Models
{
    public class FAQs
    {
        [Key]
        public int faq_id { get; set; }
        public string faq_question { get; set; }
        public string faq_answer { get; set; }
    }
}
