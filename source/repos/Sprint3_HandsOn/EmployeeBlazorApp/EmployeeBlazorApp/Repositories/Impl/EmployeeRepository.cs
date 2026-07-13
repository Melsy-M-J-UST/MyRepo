using EmployeeBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBlazorApp.Repositories.Impl
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly object _context;
        public EmployeeRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Employee> CreateAsync(Employee entity)
        {
            await _context.Set<Employee>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<Employee?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee?> UpdateAsync(int id, Employee entity)
        {
            var existing = await _context.Employee.FindAsync(id);
            if (existing is null)
            { 

                return null;

        }
        }
    }
}
