using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class PublishingHouse
    {
        [Key]
        public int id { get; set; }
        public String ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public String About { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
