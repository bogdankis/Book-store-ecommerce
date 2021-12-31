

using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public class PublishingHousesService:EntityBaseRepository<PublishingHouse>, IPublishingHousesService
    {
        public PublishingHousesService(AppDbContext context): base(context)
        {

        }
    }
}
