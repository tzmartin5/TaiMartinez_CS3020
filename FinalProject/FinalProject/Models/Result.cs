using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Result
    {
        public int ID { get; set; }

        [Display(Name = "Meet Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string MeetName { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Athlete { get; set; }

        [Required]
        public string Event { get; set; }

    
        [Display(Name = "Time/Distance")]
        [Required]
        public string Mark { get; set; }


    }
}
