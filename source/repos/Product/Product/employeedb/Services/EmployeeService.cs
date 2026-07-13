using System.Collections.Generic;
using EmployeeApp.Models;
using EmployeeApp.Repository;

namespace EmployeeApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repo;

        public EmployeeService()
        {
            _repo = new EmployeeRepository();
        }

        public List<Employee> GetAll()
        {
            return _repo.GetAll();
        }

        public Employee GetById(int id)
        {
            return _repo.GetById(id);
        }

        public string AddEmployee(Employee employee)
        {
            return _repo.AddEmployee(employee);
        }

        public string DeleteEmployee(int id)
        {
            return _repo.DeleteEmployee(id);
        }

        public string UpdateEmployee(int id, Employee employee)
        {
            return _repo.UpdateEmployee(id, employee);
        }
    }
}