using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.ViewModels
{
    public class NewBookDropdownsVM
    {

        public NewBookDropdownsVM()
        {
            Providers = new List<Provider>();
            PublishingHouses = new List<PublishingHouse>();
            Writers = new List<Writer>();
        }

        public List<PublishingHouse> PublishingHouses { get; set; }
        public List<Provider> Providers { get; set; }  
        public List<Writer> Writers { get; set; }   

    }
}
