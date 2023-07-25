using APIProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace APIProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
