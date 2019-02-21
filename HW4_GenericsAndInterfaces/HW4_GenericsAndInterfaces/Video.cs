﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW4_GenericsAndInterfaces
{
    class Video : MediaInterface
    {
        public string Path { get; set; }
        public FileInfo File { get; set ; }
        public FileType FileType { get; set ; }
        public MediaType MediaType { get ; set ; }
        public DateTime DateAdded { get ; set ; }
    }
}
