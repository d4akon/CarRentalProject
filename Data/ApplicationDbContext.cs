using CarRentalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
