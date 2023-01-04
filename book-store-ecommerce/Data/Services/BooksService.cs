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

        public async Task AddNewBookAsync(NewBookVM data)
        {
            var newBook = new Book()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageUrl = data.ImageUrl,
                ProviderId = data.ProviderId,
                ISBN = data.ISBN,
                BookCategory = data.BookCategory,
                PublishingHouseId = data.PublishingHouseId
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            //Add Book Writers
            foreach (var writerId in data.WriterIds)
            {
                var newWriterBook = new Writer_Book()
                {
                    BookId = newBook.Id,
                    WriterId = writerId
                };
                await _context.Writers_Books.AddAsync(newWriterBook);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var bookDetails = await _context.Books
                .Include(p => p.Provider)
                .Include(h => h.PublishingHouse)
                .Include(wb => wb.Writers_Books).ThenInclude(w => w.Writer)
                .FirstOrDefaultAsync(n => n.Id == id);

            return bookDetails;
        }



        public async Task<NewBookDropdownsVM> GetNewBookDropdownsValues()
        {
            var response = new NewBookDropdownsVM()
            {
                Writers = await _context.Writers.OrderBy(n => n.FullName).ToListAsync(),
                Providers = await _context.Providers.OrderBy(n => n.Name).ToListAsync(),
                PublishingHouses = await _context.PublishingHouses.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public async Task UpdateBookAsync(NewBookVM data)
        {
            var dbBook = await _context.Books.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbBook != null)
            {
                dbBook.Name = data.Name;
                dbBook.Description = data.Description;
                dbBook.Price = data.Price;
                dbBook.ImageUrl = data.ImageUrl;
                dbBook.ProviderId = data.ProviderId;
                dbBook.ISBN = data.ISBN;
                dbBook.BookCategory = data.BookCategory;
                dbBook.PublishingHouseId = data.PublishingHouseId;
                await _context.SaveChangesAsync();
            }

            //Remove existing writers
            var existingWritersDb = _context.Writers_Books.Where(n => n.BookId == data.Id).ToList();
            _context.Writers_Books.RemoveRange(existingWritersDb);
            await _context.SaveChangesAsync();

            //Add Book Writers
            foreach (var writerId in data.WriterIds)
            {
                var newWriterBook = new Writer_Book()
                {
                    BookId = data.Id,
                    WriterId = writerId
                };
                await _context.Writers_Books.AddAsync(newWriterBook);
            }
            await _context.SaveChangesAsync();
        }


    }
}
