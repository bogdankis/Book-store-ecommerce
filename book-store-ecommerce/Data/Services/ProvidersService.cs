using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public class ProvidersService: EntityBaseRepository<Provider>, IProvidersService
    {

        public ProvidersService(AppDbContext context) : base(context)
        {
            
        }
    }
}
