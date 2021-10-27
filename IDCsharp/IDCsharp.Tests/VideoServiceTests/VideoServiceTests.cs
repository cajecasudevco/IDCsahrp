using System;
using NUnit.Framework;



namespace IDCsharp.Tests.VideoServiceTests
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_return_Error()
        {
            var service = new VideoService.VideoService(new FakeFileReader());

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("Error").IgnoreCase);

        }


    }
}
