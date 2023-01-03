using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace book_store_ecommerce.Models
{
    public class Book:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }    

        [Display(Name = "Description")]
        public String Description  { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Writer")]
        public String Writer { get; set; }
        public BookCategory BookCategory { get; set; }

        [Display(Name = "ISBN")]
        public String ISBN  { get; set; }

        [Display(Name = "Image")]
        public String ImageUrl { get; set; }

        //Relationships
        public List<Writer_Book> Writers_Books { get; set; }


        //Provider
        public int ProviderId { get; set; }
        [ForeignKey("ProviderId")]
        public Provider Provider { get; set; }

        //Publishing House
        public int PublishingHouseId { get; set; }
        [ForeignKey("PublishingHouseId")]
        public PublishingHouse PublishingHouse { get; set; }

    }
}
