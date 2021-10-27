using System;
using NUnit.Framework;
using IDCsharp.VideoService;
using Moq;

namespace IDCsharp.Tests.VideoServiceTests
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_return_Error()
        {
            var mockFilereader = new Mock<IFileReader>();
            mockFilereader.Setup(fr => fr.Read("video.txt")).Returns("");


            var service = new VideoService.VideoService(mockFilereader.Object);

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("Error").IgnoreCase);

        }


    }
}
