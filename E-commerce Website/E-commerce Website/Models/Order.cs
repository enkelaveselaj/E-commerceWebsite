using System.ComponentModel.DataAnnotations;

namespace E_commerce_Website.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public int cart_id { get; set; }
        public string status { get; set; }
    }
}
