using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sd207417MIS4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        [Display(Name="Instructor First Name")]
        public string instructorFirstName { get; set; }
        [Display(Name = "Instructor Last Name")]
        public string instructorLastName { get; set; }
        [Display(Name = "Instructor Phone")]
        public string instructorPhone { get; set; }
        [Display(Name = "Instructor Email")]
        public string instructorEmail { get; set; }
        
        public string instructorFullName
        {
            get
            {
                return instructorLastName + ", " + instructorFirstName;
            }
        }
        public ICollection<Course> Course { get; set; }
    }
}