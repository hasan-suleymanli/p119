using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class VideoArgs : EventArgs
    {
        public Video Video { get; set; }
        public string CountryCode { get; set; }
    }
}
