using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace Player.Model
{
    [Serializable]
    class TrackList
    {
        private List<Track> _playList;
        //??????? метод список треков возращ копию листа 
        public List<Track> PlayList { get { return new List<Track>(_playList); } }
        public int Count { get { return _playList.Count; } }
        public string Titele { get; private set; }
        public int CurrentTrack { get; private set; }

       

        public TrackList(string name)
        {
            Titele = name;
            _playList = new List<Track>();
        }

        public Track GetTrack(int index)
        {
            if (index >= 0 && index < Count)
                return _playList[index];
            else
                return null;
        }

        public void Delete(int indexTrack)
        {
            _playList = _playList.Where(i => i.Index != indexTrack).ToList();//??
        }

        public void AddTrack(Track track)
        {

            _playList.Add(track);
        }

        public void AddTracks(params Track[] tarcks)
        {
            foreach (var track in tarcks)
                AddTrack(track);
        }
    }
}
