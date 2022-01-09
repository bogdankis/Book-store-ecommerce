using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var bookDropwdownData = await _service.GetNewBooksDropdownsValues();
            ViewBag.Providers = new SelectList(bookDropwdownData.providers, "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(bookDropwdownData.publishingHouses, "Id", "FullName");
            ViewBag.Writers = new SelectList(bookDropwdownData.writers, "Id", "FullName");

            return View();
        }
    }
}
