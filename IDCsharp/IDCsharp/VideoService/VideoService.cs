using Newtonsoft.Json;



namespace IDCsharp.VideoService
{
    public class VideoService
    {
        private IFileReader _fileReader;

        public VideoService()
        {
            _fileReader = new FileReader();
        }

        public VideoService(IFileReader fileReader)
        {
            _fileReader =  fileReader;
        }

        //MEJORA

        //public VideoService(IFileReader fileReader = null)
        //{
        //    _fileReader = fileReader ?? new FileReader();
        //}


        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }


    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }
        
}
