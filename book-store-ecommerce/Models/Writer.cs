using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Writer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Writer Picture")]
        public String ProfileImageUrl { get; set; }

        [Display(Name = "FullName")]
        public String FullName { get; set; }

        [Display(Name = "Biography")]
        public String Bio { get; set; }

        //Relationships
        public List<Writer_Book> Writers_Books { get; set;}
    }
}
