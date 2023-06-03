using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {
            
        }
        public DbSet<item> Items { get; set; }
    }
}
