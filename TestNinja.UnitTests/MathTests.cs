using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var math = new Math();

            var result = math.Add(5, 3);

            Assert.AreEqual(8, result);
            Assert.That(result, Is.EqualTo(8));
        }


        [Test]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b)
        {
            var math = new Math();


            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
