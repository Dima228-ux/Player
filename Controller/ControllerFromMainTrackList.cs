using Player.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Player.Controller
{
    partial class ControllerFromMain
    {
        //лист для папок тип txt

        public void Save()
        {
            _musicksList.Save();
        }

        public void Open()
        {
            _musicksList.Open();
        }

        public Track AddTrack(string sourceUrl, int treckListNumber)
        {
            Track track = new Track(_wmp.newMedia(sourceUrl));
            _musicksList.TrackLists[treckListNumber].AddTrack(track);
            return track;
        }

        public bool DeleteTrack(int indexTrack, int indexTrackList, string nameplayList)//либо трек или индекс
        {
            bool check = false;

            if (nameplayList == "Список музыки")
            {
                check = true;
                return check;
            }

            _musicksList.TrackLists[indexTrackList].Delete(indexTrack);
            _form.treeView1.SelectedNode.Remove();
            _form.treeView1.Update();
            return check;
        }

        public void AddTrackList(string name)
        {
            _musicksList.AddTrackList(name);
            _form.treeView1.Nodes[0].Nodes.Add(name);
        }

        public void DeleteTrackList(string name)
        {
            _musicksList.DeleteTrackList(name);
        }
    }
}
