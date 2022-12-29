using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Data.ViewModels;
using book_store_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Data.Services
{
    public class BooksService : EntityBaseRepository<Book>, IBooksService
    {
        private readonly AppDbContext _context;

        public BooksService(AppDbContext context) : base(context)
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

        public async Task<NewBooksDropdownsVM> GetNewBooksDropdownsValues()
        {
            var response = new NewBooksDropdownsVM()
            {
                writers = await _context.Writers.OrderBy(n => n.FullName).ToListAsync(),
                providers = await _context.Providers.OrderBy(n => n.Name).ToListAsync(),
                publishingHouses = await _context.PublishingHouses.OrderBy(n => n.FullName).ToListAsync(),
            };



            return response;
        }
    }
}
