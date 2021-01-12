using Events.Services;
using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video(DateTime.Now, "P119 video");
            Video video2 = new Video(new DateTime(2021,12,01,19,00,00), "316 video");

            VideoRedactor vr = new VideoRedactor();

            ConsoleService cs = new ConsoleService();
            DatabaseService ds = new DatabaseService();
            MailService ms = new MailService();

            vr.Notify += cs.OnVideoRedacted;
            vr.Notify += ds.OnVideoRedacted;
            vr.Notify += ms.OnVideoRedacted;


            vr.Redact(video);
        }
    }
}
