using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using TelescopeApp.DataBase;
using TelescopeApp.Models;

namespace TelescopeApp.Controllers
{
    public class TelescopesController : Controller
    {
        private readonly TelescopeContext _context;

        public TelescopesController(TelescopeContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllTekescopes()
        {
            _context.Telescopes.GetAsyncEnumerator();
            
            await _context.SaveChangesAsync();

            return View();
            
        }

        [HttpGet("{id}") ]

        public async Task<IActionResult> GetByTelescopesId(int? id)
        {
            var telesopes = _context.Telescopes.Where(p => p.Id == id).FirstOrDefault();

           if (id == null)
            {
                BadRequest();
            }

           await _context.SaveChangesAsync();

            return View();
            
        }


        [HttpGet("{Name}")]

        public async Task<IActionResult> GetByTelescopeName(string name)
        {

            _context.Telescopes.Where(p => p.Name  == name).FirstOrDefault();

            if (name == null)
            {
                BadRequest();
            }

            await _context.SaveChangesAsync();

            return View();
        }




    }
}
