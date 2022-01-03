using book_store_ecommerce.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class Provider:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Provider logo required")]
        public String Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Provider name required")]
        public String Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Provider descriptiom required")]
        public String Description { get; set; }
       
        public List<Book> Books { get; set;}
    }
}
