using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        public String Logo { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
       
        public List<Book> Books { get; set;}
    }
}
