using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public string email { get; set; }
        public int UserId { get; set; }

        public List<OrderItem> OrderItems { get; set;}

    }
}
