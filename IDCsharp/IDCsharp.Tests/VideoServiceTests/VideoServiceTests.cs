using System;
using NUnit.Framework;
using IDCsharp.VideoService;
using Moq;

namespace IDCsharp.Tests.VideoServiceTests
{
    [TestFixture]
    public class VideoServiceTests
    {

        private VideoService.VideoService _videoService;
        private Mock<IFileReader> _fileReader;
        

        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService.VideoService(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_return_Error()
        {

            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");


            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("Error").IgnoreCase);

        }
        [Test]
        public void ReadVideoTitle_DatosVerdaderos()
        {

            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("{ 'Id':11,'Title':'capitulo11','IsProcessed':false}");


            var result = _videoService.ReadVideoTitle();
                      

            Assert.AreEqual(result, "capitulo11");

        }


    }
}
