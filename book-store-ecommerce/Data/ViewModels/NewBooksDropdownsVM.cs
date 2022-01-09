using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.ViewModels
{
    public class NewBooksDropdownsVM
    {

        public NewBooksDropdownsVM()
        {
            providers = new List<Provider>();
            publishingHouses = new List<PublishingHouse>();
            writers = new List<Writer>();
        }

        public List<PublishingHouse> publishingHouses { get; set; }
        public List<Provider> providers { get; set; }  
        public List<Writer> writers { get; set; }   

    }
}
