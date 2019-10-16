using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        // SetUp
        // TearDown
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumofArguments()
        {
            
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
           
            var result = _math.Add(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_secondArgumentIdGreater_ReturnTheSecondArgument()
        {
            
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentAreEqual_ReturnTheSecondArgument()
        {
           
            var result = _math.Add(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
