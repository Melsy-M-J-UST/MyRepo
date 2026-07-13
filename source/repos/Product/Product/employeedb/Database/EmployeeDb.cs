using System.Collections.Generic;
using EmployeeApp.Models;

namespace EmployeeApp.Database
{
    public static class EmployeeDb
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Nandana", Gender = "F", Age = 22, Salary = 34000 }
        };
    }
}