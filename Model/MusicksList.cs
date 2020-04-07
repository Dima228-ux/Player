using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Player.Model
{
    [Serializable]
    class MusicksList
    {

        public List<TrackList> TrackLists { get; set; }

        [NonSerialized]
        private static string _path;
        private static MusicksList _ml;

        private MusicksList()
        {
            //Track = new Track(media);
            _path = "mus.dat";
            DataManager.Load(this, _path);
            TrackLists = new List<TrackList>();

        }

        public void AddTrackList(string name)
        {
            TrackLists.Add(new TrackList(name));

        }

        public void DeleteTrackList(string name)
        {
            TrackLists = TrackLists.Where(i => i.Titele != name).ToList();
        }

        public static MusicksList Initialize()
        {
            if (_ml == null)
                _ml = new MusicksList();

            return _ml;
        }

        public void Save()
        {
            DataManager.Save(this, _path);
        }

        public void Open()
        {
            DataManager.Load(this, _path);
        }
    }
}
