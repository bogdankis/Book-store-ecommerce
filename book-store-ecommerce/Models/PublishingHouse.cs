using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class PublishingHouse
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "About")]
        public string About { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
