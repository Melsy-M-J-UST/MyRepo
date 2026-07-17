using EmployeeBlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EmployeeBlazorApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Sara", Gender = "Female", Age = 23, Salary = 56000 },
new Employee { Id = 2, Name = "Anu", Gender = "Female", Age = 26, Salary = 78000 },
new Employee { Id = 3, Name = "Arun", Gender = "Male", Age = 33, Salary = 98000 },
new Employee { Id = 4, Name = "Manu", Gender = "Male", Age = 21, Salary = 34000 });  }
    }
}
