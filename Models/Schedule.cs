using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sd207417MIS4200.Models
{
    public class Schedule
    {
        [Key]
        public int scheduleID { get; set; }
        [Display(Name = "Semester")]
        public string semester { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }
    }
}