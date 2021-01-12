using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Services
{
    class DatabaseService
    {
        public void OnVideoRedacted(object source, Video video)
        {
            Console.WriteLine("Video has been redacted successfully from Database!");
            ///adding to database...
            Console.WriteLine(video.Title);
            Console.WriteLine(video.RecordedDate);
        }
    }
}
