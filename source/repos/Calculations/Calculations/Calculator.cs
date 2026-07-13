using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculator
    {
        //unit testing is repeatable.
        // Junit for Java, NUnit for C#, XUnit for C#, MSTest for C#.
        //We are using XUnit for C# unit testing.
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new InvalidDenominatorException("Denominator cannot be zero.");
            }
            return a / b;
        }

    }
}
