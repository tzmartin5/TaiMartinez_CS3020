using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW4_GenericsAndInterfaces
{
    class Video : MediaInterface
    {
        string p;
        FileInfo file;
        FileType type;
        MediaType med;
        DateTime date;

        public string Path { get => p; set => p = value; }
        public FileInfo File { get => file; set => file = value; }
        public FileType FileType { get => type; set => type = value; }
        public MediaType MediaType { get => med; set => med = value; }
        public DateTime DateAdded { get => date; set => date = value; }

       public Video()
        {

        }



    }
}
