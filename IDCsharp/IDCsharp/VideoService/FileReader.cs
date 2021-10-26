﻿using System;
using System.IO;


namespace IDCsharp.VideoService
{
    public interface IFileReader
    {
        string Read(string path);
    }

    public class FileReader : IFileReader  {


        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

    }
}
