using book_store_ecommerce.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class PublishingHouse:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureUrl { get; set; }
      
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Profile Picture is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full Name must be between 3 and 5 characters")]
        public string FullName { get; set; }

        [Display(Name = "About")]
        [Required(ErrorMessage = "Description is required")]
        public string About { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
