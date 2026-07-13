using System;
using System.Collections.Generic;
using System.Text;

namespace employeedb.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(string message) : base(message)
        {

        }
    }
}
