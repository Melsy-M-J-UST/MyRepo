using Calculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationTests
{
    public class CalculatorTests
    {
        [Fact]
        // [Fact],[Theory] are attributes

        public void Add_Given2Numbers_ReturnsSum()
        {
            //Arrange set up the test
            Calculator calc = new();
            int a = 5;
            int b = 10;
            int expected = 15;
            //Act  get the result
            int actual = calc.Add(a, b);
            //Assert  validate the result
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(3, 19, 22)]
        public void Add_Given2Numbers_ReturnsSums(int n1, int n2, int expected)
        {
            //Arrange set up the test
            Calculator calc = new();
            //Act  get the result
            int actual = calc.Add(n1, n2);
            //Assert  validate the result
            Assert.Equal(expected, actual);
        }
        [Fact] // everywhere in the test class
        public void Subtract_Given2Numbers_ReturnsDifference()
        {
            //Arrange set up the test
            Calculator calc = new();
            int a = 10;
            int b = 5;
            int expected = 5;
            //Act  get the result
            int actual = calc.Subtract(a, b);
            //Assert  validate the result
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multiply_Given2Numbers_ReturnsProduct()
        {
            //Arrange set up the test
            Calculator calc = new();
            int a = 5;
            int b = 10;
            int expected = 50;
            //Act  get the result
            int actual = calc.Multiply(a, b);
            //Assert  validate the result
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_Given2Numbers_ReturnsQuotient()
        {
            //Arrange set up the test
            Calculator calc = new();
            int a = 10;
            int b = 5;
            int expected = 2;
            //Act  get the result
            int actual = calc.Divide(a, b);
            //Assert  validate the result
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_GivenDenominatorZero_ThrowsInvalidDenominatorException()
        {
            //Arrange set up the test
            Calculator calc = new();
            int a = 10;
            int b = 0;
            //Act  get the result
            //Action act = () => calc.Divide(a, b);
            var result = Assert.Throws<InvalidDenominatorException>(() => calc.Divide(a, b));
            //Assert  validate the result
            //Assert.Throws<InvalidDenominatorException>(act);
        }
    }
    //dependecy right click project ref calculator
    // test test explorer run all tests

    ////Arrange
    //Calculator calc = new Calculator();
    ////Act  get the result
    //int result = calc.Add(1, 2);
    ////Assert  validate the result
    //Assert.Equal(3, result);
}