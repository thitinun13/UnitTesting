using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumofArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var math = new Math();
            var result = math.Add(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_secondArgumentIdGreater_ReturnTheSecondArgument()
        {
            var math = new Math();
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentAreEqual_ReturnTheSecondArgument()
        {
            var math = new Math();
            var result = math.Add(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
