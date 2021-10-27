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
            var service = new VideoService.VideoService();

            var result = service.ReadVideoTitle(new FakeFileReader());

            Assert.That(result, Does.Contain("Error").IgnoreCase);

        }


    }
}
