using book_store_ecommerce.Data;
using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public String Description  { get; set; }
        public double price { get; set; }
        public String Provider { get; set; }
        public String Writer { get; set; }
        public BookCategory BookCategory { get; set; }
        public String ISBN  { get; set; }
        public String ImageUrl { get; set; }


    }
}
