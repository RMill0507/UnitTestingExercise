using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-34, 23, 45, 34)]
        [InlineData(4, 5, 2, 11)]
        [InlineData(9, 20, 2, 31)]
        [InlineData(0, 65, 3, 68)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator challenger = new Calculator();
            

            //Act
                int actual = challenger.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(34, 12, 22)]//Add test data <-------
        [InlineData(23, 3, 20)]
        [InlineData(4, 2, 2)]
        [InlineData(65, 34, 31)]
        [InlineData(5, 2, 3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            Calculator test = new Calculator();

            int actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        [InlineData(7, 5, 35)]
        [InlineData(5, 3, 15)]
        [InlineData(4, 1, 4)]
        [InlineData(34, 2, 68)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            Calculator test = new Calculator();

            int actual = test.Mult(num1, num2);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 3, 2)]//Add test data <-------
        [InlineData(10, 5, 2)]
        [InlineData(16, 4, 4)]
        [InlineData(20, 5, 4)]
        [InlineData(100, 25, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator test = new Calculator();

            int actual = test.Divide(num1, num2);

            Assert.Equal(expected, actual);

        }

    }
}
