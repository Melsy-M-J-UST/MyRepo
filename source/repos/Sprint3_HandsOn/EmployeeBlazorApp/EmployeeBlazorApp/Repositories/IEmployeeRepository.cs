using EmployeeBlazorApp.Models;

namespace EmployeeBlazorApp.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task<Employee> CreateAsync(Employee entity);
        Task<Employee?> UpdateAsync(int id, Employee entity);
        Task<Employee?> DeleteAsync(int id);
    }
}
