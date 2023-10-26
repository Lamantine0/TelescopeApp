using Microsoft.AspNetCore.Mvc;
using TelescopeApp.DataBase;

namespace TelescopeApp.Controllers
{
    public class TelescopesController : Controller
    {
        private readonly TelescopeContext _context;

        public TelescopesController(TelescopeContext context)
        {
            _context = context;
        }

    }
}
