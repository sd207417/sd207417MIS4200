using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sd207417MIS4200.Models
{
    public class Instructor
    {
        [Key]
        public int instructorID { get; set; }
        [Display(Name = "Instructor Name")]
        public string instructorFullName{get{return instructorLastName + ", " + instructorFirstName;}}


        [Display(Name="Instructor First Name")]
        [Required]
        [StringLength(200)]
        public string instructorFirstName { get; set; }
        
        [Display(Name = "Instructor Last Name")]
        [Required]
        [StringLength(200)]
        public string instructorLastName { get; set; }
        [Display(Name = "Department")]
        public string instructorDepartment { get; set; }
        [Display(Name = "Instructor Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in teh format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string instructorPhone { get; set; }

        [Required]
        [Display(Name = "Instructor Email")]
        public string instructorEmail { get; set; }

        
        
        public ICollection<Course> Course { get; set; }
    }
}