using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


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

        //GET: Book/Create
        public async Task<IActionResult> Create()
        {
            var bookDropdownsData = await _service.GetNewBookDropdownsValues();

            ViewBag.Providers = new SelectList(bookDropdownsData.Providers, "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(bookDropdownsData.PublishingHouses, "Id", "FullName");
            ViewBag.Writers = new SelectList(bookDropdownsData.Writers, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM book)
        {
            if (!ModelState.IsValid)
           {
                var bookDropdownsData = await _service.GetNewBookDropdownsValues();

                ViewBag.Providers = new SelectList(bookDropdownsData.Providers, "Id", "Name");
                ViewBag.PublishingHouses = new SelectList(bookDropdownsData.PublishingHouses, "Id", "FullName");
                ViewBag.Writers = new SelectList(bookDropdownsData.Writers, "Id", "FullName");
                return View(book);
           }
            await _service.AddNewBookAsync(book);
            return RedirectToAction(nameof(Index));
        } 
            

    }
}
