using book_store_ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace book_store_ecommerce.Controllers
{
    public class WritersController : Controller
    {
        private readonly AppDbContext _context;

        public WritersController(AppDbContext context)  //inject db context in constructor
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Writers.ToList();
            return View();
        }
    }
}
