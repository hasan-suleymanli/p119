using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Services
{
    class MailService
    {
        public void OnVideoRedacted(object source, Video video)
        {
            Console.WriteLine("Video has been redacted successfully from Mail!");
            //sending to mail...
            Console.WriteLine(video.Title);
            Console.WriteLine(video.RecordedDate);
        }
    }
}
