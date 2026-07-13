using System.Collections.Generic;
using System.Linq;
using EmployeeApp.Models;
using EmployeeApp.Database;
using employeedb.Exceptions;

namespace EmployeeApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAll()
        {
            return EmployeeDb.Employees;
        }

        public Employee GetById(int id)
        {
            var emp = EmployeeDb.Employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                throw new EmployeeNotFoundException($"Employee with id {id} not found");

            return emp;
        }

        public string AddEmployee(Employee employee)
        {
            EmployeeDb.Employees.Add(employee);
            return "Employee Added";
        }

        public string DeleteEmployee(int id)
        {
            var emp = GetById(id);
            EmployeeDb.Employees.Remove(emp);
            return "Employee Deleted";
        }

        public string UpdateEmployee(int id, Employee employee)
        {
            var existing = GetById(id);

            existing.Name = employee.Name;
            existing.Age = employee.Age;
            existing.Gender = employee.Gender;
            existing.Salary = employee.Salary;

            return "Employee Updated";
        }
    }
}