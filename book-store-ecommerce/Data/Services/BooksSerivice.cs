using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public class BooksSerivice: EntityBaseRepository<Book>, IBooksService
    {
        public BooksSerivice(AppDbContext context) : base(context)
        {
             
        }
    }
}
