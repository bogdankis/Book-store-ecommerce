using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public String Logo { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Description")]
        public String Description { get; set; }
       
        public List<Book> Books { get; set;}
    }
}
