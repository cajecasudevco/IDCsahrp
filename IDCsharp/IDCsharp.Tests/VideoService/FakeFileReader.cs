using System;
using IDCsharp.VideoService;


namespace IDCsharp.Tests.VideoService
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
