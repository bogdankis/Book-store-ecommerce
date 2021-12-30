using book_store_ecommerce.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Writer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name ="Writer Picture")]
        [Required(ErrorMessage = "Image Required ")]
        public String ProfileImageUrl { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name Required ")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full name must be between 3 and 50 characters")]
        public String FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Bio Required ")]
        public String Bio { get; set; }

        //Relationships
        public List<Writer_Book> Writers_Books { get; set;}
    }
}
