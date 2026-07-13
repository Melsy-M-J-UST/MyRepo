using Calculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationTests
{
    public class NamesTest
    {
        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            //Arrange set up the test
            Names names = new Names();// Names names = new();       NA with var datatypes
            string firstName = "John";
            string lastName = "Doe";
            string expected = "John Doe";
            //Act  get the result
            string actual = names.GetFullName(firstName, lastName);
            //Assert  validate the result
            Assert.Equal(expected, actual, ignoreCase: true);
            Assert.NotNull(actual);
            Assert.StartsWith("John", actual);
            Assert.EndsWith("Doe", actual);
        }
    }
}