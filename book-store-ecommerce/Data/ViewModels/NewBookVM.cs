using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace book_store_ecommerce.Models
{
    public class NewBookVM
    {
        [Display(Name = "Book name")]
        [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; }

        [Display(Name = "Book description")]
        [Required(ErrorMessage = "Description is required")]
        public String Description  { get; set; }

        [Display(Name = "Book price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double price { get; set; }

        [Display(Name = "Select writer")]
        [Required(ErrorMessage = "Writer is required")]
        public String Writer { get; set; }
        public BookCategory BookCategory { get; set; }

        [Display(Name = "Book ISBN")]
        [Required(ErrorMessage = "ISBN is required")]
        public String ISBN  { get; set; }

        [Display(Name = "Book cover")]
        [Required(ErrorMessage = "Book Cover URL is required")]
        public String ImageUrl { get; set; }

        //Relationships
        public List<int> WriterIds { get; set; }

        [Display(Name = "Select a provider")]
        [Required(ErrorMessage = "Provider is required")]
        public int ProviderId { get; set; }

        [Display(Name = "Select a publishing house")]
        [Required(ErrorMessage = "Publishing House is required")]
        public int PublishingHouseId { get; set; }


    }
}
