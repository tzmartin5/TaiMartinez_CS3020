using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final_WPHS_Track.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string EventPref { get; set; }
        public string Phone { get; set; }
    }
}
