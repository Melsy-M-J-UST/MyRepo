using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationTests
{
    internal class InvalidDenominatorException : Exception
    {
        public InvalidDenominatorException(string? message) : base(message)
        {
        }
    }
}
