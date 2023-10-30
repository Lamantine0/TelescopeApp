using Microsoft.EntityFrameworkCore;
using TelescopeApp.Models;

namespace TelescopeApp.DataBase
{
    public class TelescopeContext : DbContext
    {
        public TelescopeContext(DbContextOptions<TelescopeContext> options) 
            : base(options)
        {
      
        
        }

        public DbSet<Telescope> Telescopes { get; set; } = null!;
    }


}
