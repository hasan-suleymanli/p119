using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Video
    {
        public DateTime RecordedDate { get; set; }
        public string Title { get; set; }

        public Video(DateTime recordedDate, string title)
        {
            RecordedDate = recordedDate;
            Title = title;
        }
    }
}
