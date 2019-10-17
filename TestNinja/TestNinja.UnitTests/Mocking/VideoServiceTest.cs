using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTest
    {
        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _repository;
        
        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _repository = new Mock<IVideoRepository>();
            _videoService = new VideoService(_fileReader.Object, _repository.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
        [Test]
        public void GetUnprocessedVideoAsCsv_AllVideosAreProcessed_ReturnAnEmptyString()
        {
            _repository.Setup(ref => r.GetUnprocessedVideos()).Rrturns(new List<Video>());
            var result = _videoService.GetUnprocessedVideoAsCsv();
            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void GetUnprocessedVideoAsCsv_AFewUnprocessedVideos_ReturnAStringWithIdOfUnprocessedVideos()
        {
            _repository.Setup(ref => r.GetUnprocessedVideos()).Rrturns(new List<Video>);
            {
                new Video { Id = 1},
                new Video { Id = 2 },
                new Video { Id = 3 },
            });
            var result = _videoService.GetUnprocessedVideoAsCsv();
            Assert.That(result, Is.EqualTo(""));
        }
    } 
}
