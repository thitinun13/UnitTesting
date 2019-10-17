using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTest
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoServiceTest();
            var result = service.ReadVideoTitle(new FakeFileReader());
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
