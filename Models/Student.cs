using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sd207417MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        public string studentFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string studentLastName { get; set; }
        [Display(Name = "Phone")]
        public string studentPhone { get; set; }
        [Display(Name = "Email")]
        public string studentEmail { get; set; }
        [Display(Name = "Major")]
        public string studentMajor { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public string studentFullName 
        { get
            { 
                return studentLastName + ", " + studentFirstName; 
            }
        }

    }
}