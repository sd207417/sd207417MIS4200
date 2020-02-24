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
        [Required]
        [StringLength(50)]
        public string courseSection { get; set; }

        [Display(Name = "Course Description")]
        [Required]
        [StringLength(50)]
        public string courseDescription { get; set; }
        [Display(Name = "Offered Online")]
        
        public bool courseOnline { get; set; }
        [Display(Name = "Time")]
        [Required]
        [StringLength(20,MinimumLength =15,ErrorMessage = "Enter time as show: MWF 10:45-12:00pm or TTh 10:45-12:00pm")]
        public string courseTime { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

        public ICollection<Schedule> Schedule { get; set; }


    }
}