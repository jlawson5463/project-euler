using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler
{
    public class EvenFibonacciNumbers
    {
        public int Calculate(int number)
        {
            var fibNumbers = new List<int> { 1, 2 };
            for (var i = 2; i < number; i++)
            {
                fibNumbers.Add(fibNumbers[i - 1] + fibNumbers[i - 2]);
            }

            return fibNumbers.Where(x => x % 2 == 0).Sum();
        }
    }

    public class EvenFibonacciNumbers_Tests
    {
        [Theory]
        [InlineData(10, 44)]
        [InlineData(18, 3382)]
        [InlineData(23, 60696)]
        [InlineData(43, 350704366)]
        public void Test(int number, int expectedResult)
        {
            var sut = new EvenFibonacciNumbers();
            var result = sut.Calculate(number);
            Assert.Equal(expectedResult, result);
        }
    }
}
