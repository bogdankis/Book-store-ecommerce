using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Controllers
{
    public class ProvidersController : Controller
    {

        private readonly IProvidersService _service;

        public ProvidersController(IProvidersService service)  //inject db context in constructor
        {

            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProviders = await _service.GetAllAsync();
            return View(allProviders);
        }


        //Get: Providers/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Provider provider)
        {
            if (!ModelState.IsValid)
            {
                return View(provider);
            }
            await _service.AddAsync(provider);
            return RedirectToAction(nameof(Index));
        }

        //Get: Providers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var providersDetails = await _service.GetByIdAsync(id);
            if(providersDetails == null)
            {
                return View("NotFound");
            }
            return View(providersDetails);
        }

        //Get: Provider/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var providersDetails = await _service.GetByIdAsync(id);
            if (providersDetails == null)
            {
                return View("NotFound");
            }
            return View(providersDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Provider provider)
        {
            if (!ModelState.IsValid)
            {
                return View(provider);
            }
            await _service.UpdateAsync(id,provider);
            return RedirectToAction(nameof(Index));
        }

        //Get: Provider/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var providersDetails = await _service.GetByIdAsync(id);
            if (providersDetails == null)
            {
                return View("NotFound");
            }
            return View(providersDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmation(int id)
        {
            var providersDetails = await _service.GetByIdAsync(id);
            if (providersDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
