using System;
using EmployeeApp.Services;
using EmployeeApp.Models;
using employeedb.Exceptions;

class Program
{
    static void Main()
    {
        IEmployeeService service = new EmployeeService();

        while (true)
        {
            Console.WriteLine("\n1. Display All");
            Console.WriteLine("2. Get By Id");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var employees = service.GetAll();
                    employees.ForEach(e => Console.WriteLine(e));
                    break;

                case 2:
                    try
                    {
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(service.GetById(id));
                    }
                    catch (EmployeeNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 3:
                    Employee emp = new Employee();

                    Console.Write("Id: ");
                    emp.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    emp.Name = Console.ReadLine();
                    Console.Write("Age: ");
                    emp.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Gender: ");
                    emp.Gender = Console.ReadLine();
                    Console.Write("Salary: ");
                    emp.Salary = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine(service.AddEmployee(emp));
                    break;

                case 4:
                    Console.Write("Enter ID to delete: ");
                    int delId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(service.DeleteEmployee(delId));
                    break;

                case 5:
                    return;
            }
        }
    }
}