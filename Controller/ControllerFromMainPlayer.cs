using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.IO;
using Player.Model;
using Player.Viev;
using System.Drawing;
using System.Windows.Forms;

namespace Player.Controller
{
    partial class ControllerFromMain
    {
        private bool _isPlay;
        private Timer _timer;
        private bool _check;
        public Track CurrentAudio => _musicksList.TrackLists[_indexPlayList].GetTrack(_indexTrack);
        public TimeSpan PositionTime => TimeSpan.FromSeconds((int)_wmp.controls.currentPosition);
        public bool IsPlay { get { return _isPlay; } }

        public double Position
        {
            get { return _wmp.controls.currentPosition; }
            set { _wmp.controls.currentPosition = value; }
        }

        public void Pause()
        {
            //подписать трек бар на позишен чейнжд 100\d*Posistion
            _wmp.controls.pause();
            _timer.Stop();
            _isPlay = false;
            _form.buttonPlay.BackgroundImage = new Bitmap(_form.imageList1.Images[0]);
            _check = true;
        }

        public void AddTrackOnTreeView(Track track)
        {
            _form.treeView1.Nodes[0].Nodes[_form.treeView1.SelectedNode.Index].Nodes.Add(track.NameTrack);
        }

        public double Duraction()
        {
            return CurrentAudio.Duration;
        }
        public TimeSpan DuractionTime()
        {
            return CurrentAudio.DurationTime;
        }

        public void Play(int indextrack)
        {
            if (_check == false&&_form.treeView1.SelectedNode.Index>-1)
            {
                _indexPlayList = _form.treeView1.SelectedNode.Parent.Index;
                if (_musicksList.TrackLists[_indexPlayList].Count == -1)
                    return;

                SelectAudio(indextrack, _indexPlayList);
                _form.labelDuractionTimeTrack.Text = DuractionTime().ToString();
                _form.labelNameTrack.Text = CurrentAudio.NameTrack;
                _form.trackBarTrack.Maximum = (int)Duraction();
            }
            else
            {
                _timer.Start();
            }

            _wmp.controls.play();
            _isPlay = true;
            _form.buttonPlay.BackgroundImage = new Bitmap(_form.imageList1.Images[1]);
            _check = false;
        }

        public void SelectAudio(int index, int indexTrackList)
        {
            this._indexTrack = index;

            if (this._indexTrack >= _musicksList.TrackLists[indexTrackList].Count)
                this._indexTrack = 0;

            if (this._indexTrack < 0)
                this._indexTrack = _musicksList.TrackLists[indexTrackList].Count - 1;
            _wmp.currentMedia = CurrentAudio.Media;
            _timer.Start();

        }
        
        public void Progress()
        {
            _timer = new Timer() { Interval = 1 };
            _timer.Tick += (s, e) =>
            {

                if (PositionTime.TotalSeconds >= (int)CurrentAudio.DurationTime.TotalSeconds || IsPlay == false)
                {
                    ((Timer)s).Stop();
                    Stop();
                    _isPlay = false;
                    _isPlay = true;
                    Play(NextTrack(_indexPlayList,_indexTrack ));
                   
                }

                _form.trackBarTrack.Value = (int)Position;
                _form.labelTimePlaying.Text = PositionTime.ToString();
            };
        }

        public string OpenFormEnterPlayListName()
        {
            FormEnterPlayListName f = new FormEnterPlayListName();
            f.ShowDialog();
            return f.Title;
        }

        public void Stop()
        {
            _wmp.controls.stop();
            _timer.Stop();
            _isPlay = false;
            _form.buttonPlay.Image =new Bitmap( _form.imageList1.Images[0]);
        }



        public int NextTrack(int indexPlayList, int indexTrack)
        {
            if (_musicksList.TrackLists[indexPlayList].Count - 1 != indexTrack)
                return ++indexTrack;
            else
                return indexTrack = 0;
        }

        public int PreviousTrack(int indexPlayList, int indexTrack)
        {
            if (indexTrack != 0)
                return --indexTrack;
            else
                return _musicksList.TrackLists[indexPlayList].Count - 1;
        }
     
    }
}

