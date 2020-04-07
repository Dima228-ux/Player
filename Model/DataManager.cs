using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Player.Model
{
    class DataManager
    {
        public static void Save(MusicksList mData, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))

                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, mData);
                }
            }
            catch { }
        }
        public static void Load( MusicksList mData, string path)
        {
            try
            {

                if (!File.Exists(path))
                    return;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    mData = (MusicksList)bf.Deserialize(fs);
                }
            }
            catch  {  }
        }
    }
}

