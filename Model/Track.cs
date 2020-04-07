using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Player.Model
{
    [Serializable]
    class Track
    {
        public string NameTrack { get; set; }
        public double Duration { get; private set; }
        public TimeSpan DurationTime => TimeSpan.FromSeconds(Duration);
        public string SourceUrl { get; private set; }
        public IWMPMedia Media { get; private set; }
        public int Index { get; set; }

        public Track(IWMPMedia media)
        {
            Media = media;
            Duration = Media.duration;
            SourceUrl = Media.sourceURL;
            NameTrack = Path.GetFileNameWithoutExtension(SourceUrl);
            Index++;
        }

    }
}
