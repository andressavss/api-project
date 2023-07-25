using APIProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace APIProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        DbSet<Department> Departments { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
