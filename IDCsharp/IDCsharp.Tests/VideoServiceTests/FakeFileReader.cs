using System;
using IDCsharp.VideoService;



namespace IDCsharp.Tests.VideoServiceTests
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
