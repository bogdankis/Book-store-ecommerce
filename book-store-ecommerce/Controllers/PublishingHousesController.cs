using book_store_ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Controllers
{
    public class PublishingHousesController : Controller
    {
        private readonly AppDbContext _context;

        public PublishingHousesController(AppDbContext context) //inject db context in constructor
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var publishingHouses = await _context.PublishingHouses.ToListAsync();
            return View(publishingHouses);
        }
    }
}
