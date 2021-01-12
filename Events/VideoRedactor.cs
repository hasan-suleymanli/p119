using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class VideoRedactor
    {
        //public delegate void VideoRedactorHandler(object source, VideoArgs args);
        //public event VideoRedactorHandler Notify;

        public event EventHandler<VideoArgs> Notify;
        public void Redact(Video video)
        {
            Console.WriteLine("Redacting video...");

            OnRedacted(video);
        }

        public void OnRedacted(Video video)
        {
            Notify?.Invoke(this, new VideoArgs { Video = video });
        }
    }
}
