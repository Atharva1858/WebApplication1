using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MvcDemo : DbContext
    {
        public MvcDemo(DbContextOptions <MvcDemo> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
