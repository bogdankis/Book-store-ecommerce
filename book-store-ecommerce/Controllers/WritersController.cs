﻿using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Mvc;


namespace book_store_ecommerce.Controllers
{
    public class WritersController : Controller
    {
        private readonly IWritersService _service; 

        public WritersController(IWritersService service)  //inject db context in constructor
        {
            _service = service;
        }

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
            if (!ModelState.IsValid) //checks if models state required is valid - delete <Nullable>enable<Nullable> in order to work, only valid for .NET 6
            {
                return View(writer);
            }

            await _service.AddAsync(writer);
            return RedirectToAction(nameof(Index));
        }

        //Get: Writers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var writerDetails = await _service.GetByIdAsync(id);

            if (writerDetails == null)
            {
                return View("Empty");
            }
                
            return View(writerDetails);
        }
    }
}
