using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace book_store_ecommerce.Controllers
{
    [Authorize]  //check if you're logged 
    public class WritersController : Controller
    {
        private readonly IWritersService _service; 

        public WritersController(IWritersService service)  //inject db context in constructor
        {
            _service = service;
        }
        [AllowAnonymous]  // allow unauthenticated users
        public async Task<IActionResult> Index() //Show all writers
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get: Writers/Create
        public IActionResult Create() //create writer
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfileImageUrl,FullName,Bio")] Writer writer)
        {
            if (!ModelState.IsValid)                 //checks if models state required is valid - delete <Nullable>enable<Nullable> in order to work, only valid for .NET 6
            {
                return View(writer);
            }

            await _service.AddAsync(writer);
            return RedirectToAction(nameof(Index));
        }



        //Get: Writers/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var writerDetails = await _service.GetByIdAsync(id);

            if (writerDetails == null)
            {
                return View("NotFound");
            }
                
            return View(writerDetails);
        }


        //Get: Writers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var writerDetails = await _service.GetByIdAsync(id);

            if (writerDetails == null)
            {
                return View("NotFound");
            }
            return View(writerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfileImageUrl,FullName,Bio")] Writer writer)                     //edit writer
        {
            if (!ModelState.IsValid)
            {
                return View(writer);
            }
            await _service.UpdateAsync(id, writer);
            return RedirectToAction(nameof(Index));
        }


        //Get:Writers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var writerDetails = await _service.GetByIdAsync(id);

            if(writerDetails == null)
            {
                return View("NotFound");
            }
            return View(writerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var writerDetails = await _service.GetByIdAsync(id);

            if (writerDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
