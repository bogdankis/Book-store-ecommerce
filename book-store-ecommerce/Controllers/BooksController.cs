using book_store_ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)  //inject db context in constructor
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allBooks = await _context.Books.Include(n => n.Provider).OrderBy(n => n.Name).ToListAsync(); //order by name
            return View(allBooks);
        }
    }
}
