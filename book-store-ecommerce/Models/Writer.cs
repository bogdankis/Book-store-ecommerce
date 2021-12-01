using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Writer
    {
        [Key]
        public int Id { get; set; }
        public String ProfileImageUrl { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }

        //Relationships
        public List<Writer_Book> Writers_Books { get; set;}
    }
}
