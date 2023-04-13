using Microsoft.EntityFrameworkCore;
using worldapi.Models;

namespace worldapi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }

    }

        
}
