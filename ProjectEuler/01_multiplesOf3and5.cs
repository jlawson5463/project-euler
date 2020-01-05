using Xunit;

namespace ProjectEuler
{
    public class MultiplesOf3and5
    {
        public double Calculate(int number)
        {
            var total = 0;
            for (var i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }

    public class MultiplesOf3and5_Tests
    {
        [Theory]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        [InlineData(19564, 89301183)]
        [InlineData(8456, 16687353)]
        public void Test(int number, int expectedResult)
        {
            var sut = new MultiplesOf3and5();
            var result = sut.Calculate(number);
            Assert.Equal(expectedResult, result);
        }
    }
}
