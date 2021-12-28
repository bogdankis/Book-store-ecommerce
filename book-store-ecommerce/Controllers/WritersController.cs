﻿using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
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

        public async Task<IActionResult> Index() //Show all actors
        {
            var data = await _service.GetAll();
            return View(data);
        }
        //Get: Actors/Create
        public IActionResult Create() //create actor
        {
            return View();
        }
    }
}
