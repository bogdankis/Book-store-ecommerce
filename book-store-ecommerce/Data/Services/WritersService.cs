using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Data.Services
{
    public class WritersService : EntityBaseRepository<Writer>, IWritersService
    {
        private readonly AppDbContext _context;
        public WritersService(AppDbContext context): base(context) //pass appdbcontext to baseclass
        {
        }
    }
}
