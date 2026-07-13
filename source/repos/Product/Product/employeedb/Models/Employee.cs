using System;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Gender:{Gender}, Salary:{Salary}";
        }
    }
}