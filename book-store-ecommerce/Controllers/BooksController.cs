using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Data.Static;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace book_store_ecommerce.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class BooksController : Controller
    {
        private readonly IBooksService _service;

        public BooksController(IBooksService service)  //inject db context in constructor
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allBooks = await _service.GetAllAsync(n => n.Provider); //order by name
            return View(allBooks);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString) 
        {
            var allBooks = await _service.GetAllAsync(n => n.Provider); //order by name
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allBooks.Where(n => n.Name.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Index",filteredResult);
            }
            return View("Index", allBooks);
        }

        //GET: Books/Details/1
        [AllowAnonymous]
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

        //GET: Book/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var bookDetails = await _service.GetBookByIdAsync(id);
            if (bookDetails == null) return View("NotFound"); // if book doesn t exist show Notfound page

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Name = bookDetails.Name,
                Description = bookDetails.Description,
                Price = bookDetails.Price,
                ISBN = bookDetails.ISBN,
                ImageUrl = bookDetails.ImageUrl,
                BookCategory = bookDetails.BookCategory,
                PublishingHouseId = bookDetails.PublishingHouseId,
                ProviderId = bookDetails.ProviderId,
                WriterIds = bookDetails.Writers_Books.Select(n => n.WriterId).ToList(),
            };

            var bookDropdownsData = await _service.GetNewBookDropdownsValues();

            ViewBag.Providers = new SelectList(bookDropdownsData.Providers, "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(bookDropdownsData.PublishingHouses, "Id", "FullName");
            ViewBag.Writers = new SelectList(bookDropdownsData.Writers, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewBookVM book)
        {
            if (id != book.Id) return View("NotFound"); // if book doesn t exist show Notfound page


            if (!ModelState.IsValid)
            {
                var bookDropdownsData = await _service.GetNewBookDropdownsValues();

                ViewBag.Providers = new SelectList(bookDropdownsData.Providers, "Id", "Name");
                ViewBag.PublishingHouses = new SelectList(bookDropdownsData.PublishingHouses, "Id", "FullName");
                ViewBag.Writers = new SelectList(bookDropdownsData.Writers, "Id", "FullName");
                return View(book);
            }
            await _service.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

    }
}
