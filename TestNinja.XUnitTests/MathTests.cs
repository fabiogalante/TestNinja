using Xunit;

namespace TestNinja.XUnitTests
{
    public class MathTests
    {
        private readonly Fundamentals.Math _math;


        public MathTests()
        {
            _math = new Fundamentals.Math();
        }

        [Fact]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {  
            var result = _math.Add(5, 3);
            Assert.Equal(8, result);   
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 1, 3)]
        [InlineData(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);
            Assert.Equal(expected, result);

        }
    }
}
