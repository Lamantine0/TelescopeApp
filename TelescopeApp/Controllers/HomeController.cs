﻿using Microsoft.AspNetCore.Mvc;
using TelescopeApp.Models;

namespace TelescopeApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Поле Привета");
        }


    

        public IActionResult CreateTelescope(Telescope telescope)
        {
            if(ModelState.IsValid)
            {
                return View(telescope);
            }

            return View("Index");
        }
    }
}
