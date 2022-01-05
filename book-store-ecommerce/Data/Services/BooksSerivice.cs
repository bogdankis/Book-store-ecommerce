using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Data.Services
{
    public class BooksSerivice: EntityBaseRepository<Book>, IBooksService
    {
        private readonly AppDbContext _context;

        public BooksSerivice(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var bookDetails = await _context.Books
                .Include(p => p.Provider)
                .Include(pb => pb.PublishingHouse)
                .Include(wb => wb.Writers_Books).ThenInclude(w => w.Writer)
                .FirstOrDefaultAsync(n => n.Id == id);

            return bookDetails;
        }
    }
}
