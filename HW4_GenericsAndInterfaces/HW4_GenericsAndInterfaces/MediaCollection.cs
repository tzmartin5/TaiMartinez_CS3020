using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW4_GenericsAndInterfaces
{
    class MediaCollection<T> where T : MediaInterface
    {
         //can be used for audio, video, and sound 
        List<T> collection = new List<T>();


        public MediaCollection()
        {

        }


        //add object to collection list 
        public void Add(T obj)
        {
            collection.Add(obj);
        }



        public void OpenOrPlay(T file)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(file.Path);
            player.Play();
        }




    }
}
