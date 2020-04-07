using Player.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Player.Controller
{
    partial class ControllerFromMain
    {
        private FormMain _form;
        private WindowsMediaPlayer _wmp;
        private int _indexTrack;
        private int _indexPlayList;
        private MusicksList _musicksList;

        public ControllerFromMain(FormMain sender)
        {
            _wmp = new WindowsMediaPlayer();
            _form = sender;
           _indexTrack = 0;
            _isPlay = false;
            _musicksList= MusicksList.Initialize();
            _indexPlayList = 0;
            Progress();
            
        }
    }
}
