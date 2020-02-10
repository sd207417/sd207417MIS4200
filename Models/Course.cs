using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace sd207417MIS4200.Models
{
    public class Course
    {
        [Key]
        public int courseID { get; set; }
        [Display(Name = "Course Section")]
        public string courseSection { get; set; }

        [Display(Name = "Course Description")]
        public string courseDescription { get; set; }
        [Display(Name = "Time")]
        public string courseTime { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

        public ICollection<Schedule> Schedule { get; set; }


    }
}