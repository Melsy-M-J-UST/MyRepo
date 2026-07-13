using System.Collections.Generic;
using EmployeeApp.Models;

namespace EmployeeApp.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        string AddEmployee(Employee employee);
        string DeleteEmployee(int id);
        string UpdateEmployee(int id, Employee employee);
    }
}