using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Services
{
    class ConsoleService
    {
        public void OnVideoRedacted(object source, Video video)
        {
            Console.WriteLine("Video has been redacted successfully from Console!");
            Console.WriteLine(video.Title);
            Console.WriteLine(video.RecordedDate);
        }
    }
}
