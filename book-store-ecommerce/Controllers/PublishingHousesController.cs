using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace book_store_ecommerce.Controllers
{
    [Authorize]
    public class PublishingHousesController : Controller
    {
        private readonly IPublishingHousesService _service;

        public PublishingHousesController(IPublishingHousesService  service) //inject in constructor
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var publishingHouses = await _service.GetAllAsync();
            return View(publishingHouses);
        }

        //GET: PublishingHouses/Create/
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureUrl,FullName,About")] PublishingHouse publishingHouse)
        {
            if (!ModelState.IsValid)
            {
                return View(publishingHouse);
            }
            await _service.AddAsync(publishingHouse);
            return RedirectToAction(nameof(Index));
        }

        //GET: PublishingHouses/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id) //check if data exists in db, if exits return to view
        {
            var publishingHousesDetails = await _service.GetByIdAsync(id);
            if (publishingHousesDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(publishingHousesDetails);
            }

        }
        //GET: PublishingHouses/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var publishingHousesDetails = await _service.GetByIdAsync(id);
            if(publishingHousesDetails == null)
            {
                return View("NotFound");
                    }
            return View(publishingHousesDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind( "Id,ProfilePictureUrl,FullName,About")] PublishingHouse publishingHouse)
        {
            if (!ModelState.IsValid)
            {
                return View(publishingHouse);
            }
            if(id == publishingHouse.Id)
            {
            await _service.UpdateAsync(id, publishingHouse);
            return RedirectToAction(nameof(Index));
            }
            return View(publishingHouse);
        }

        //GET: PublishingHouses/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var publishingHousesDetails = await _service.GetByIdAsync(id);
            if (publishingHousesDetails == null)
            {
                return View("NotFound");
            }
            return View(publishingHousesDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publishingHousesDetails = await _service.GetByIdAsync(id);
            if (publishingHousesDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
