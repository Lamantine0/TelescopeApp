using Microsoft.AspNetCore.Mvc;
using TelescopeApp.Models;

namespace TelescopeApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Поле Привета");
        }


        public IActionResult AddTelescope()
        {
           
           // return Content("Наш метод добовления телескопа");

            return View("AddTelescope");
        }
    }
}
