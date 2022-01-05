using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _service;

        public BooksController(IBooksService service)  //inject db context in constructor
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allBooks = await _service.GetAllAsync(n => n.Provider); //order by name
            return View(allBooks);
        }

        //GET: Books/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var bookDetail = await _service.GetBookByIdAsync(id);
            return View(bookDetail);
        }
    }
}
