using Player.Model;
using Player.Viev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.Controller
{
    class ControllerFromEnterPlayListName
    {
        public string Name { get; set; }
        
        private FormEnterPlayListName _form;

        public ControllerFromEnterPlayListName(FormEnterPlayListName f)
        {
            _form = f;
        }
    }
}
