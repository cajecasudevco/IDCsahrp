using System;
using System.IO;


namespace IDCsharp.VideoService
{
    public class FileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

    }
}
