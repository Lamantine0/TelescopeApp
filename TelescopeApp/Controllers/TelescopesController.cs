using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using TelescopeApp.DataBase;
using TelescopeApp.Models;

namespace TelescopeApp.Controllers
{
    [Route("[controller]")]
    public class TelescopesController : Controller
    {
        private readonly TelescopeContext _context;

        public TelescopesController(TelescopeContext context)
        {
            _context = context;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllTekescopes()
        {
            _context.Telescopes.GetAsyncEnumerator();
            
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

           // return View();
            
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


        [HttpPost("{Pictures}")]

        public async Task<IActionResult> AddTelescopePictures(Telescope telescope , IFormFile Picture)
        {
            if (Picture != null && Picture.Length > 0)
            {
                byte[]? imageData = null;

                using(var binaryRider = new BinaryReader(Picture.OpenReadStream()))
                {

                    imageData = binaryRider.ReadBytes((int) Picture.Length);
                }

                telescope.Picture = imageData;
            }

            _context.Add(telescope);

            await _context.SaveChangesAsync();

            return View();
        }


        [HttpPost("{telescope}")]

        public async Task<IActionResult>CreateTelescope(Telescope telescope)
        {
            if (ModelState.IsValid)
            {
                _context.Telescopes.Add(telescope);
               
                await _context.SaveChangesAsync();

                return RedirectToAction("AddTelescope");



            }

            return View(telescope);

            
        }




    }
}
