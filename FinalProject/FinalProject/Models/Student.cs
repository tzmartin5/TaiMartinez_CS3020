using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Student
    {

        public int ID { get; set; }


        [StringLength(100, MinimumLength = 5)]
        [Required]
        public string Name { get; set; }

        [Range(9,12)]
        [Required]
        public int Grade { get; set; }

        [Display(Name = "Event Preferences")]
        public string EventPref { get; set; }


        [Required]
        [StringLength(70, MinimumLength = 10)]
        public string Phone { get; set; }




    }
}
