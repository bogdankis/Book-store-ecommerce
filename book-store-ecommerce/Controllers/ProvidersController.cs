using book_store_ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Controllers
{
    public class ProvidersController : Controller
    {

        private readonly AppDbContext _context;

        public ProvidersController(AppDbContext context)  //inject db context in constructor
        {
            
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProviders = await _context.Providers.ToListAsync();
            return View(allProviders);
        }
    }
}
