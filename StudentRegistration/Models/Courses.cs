using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }

        [DisplayName("Course Name")]
        [Required]
        public string CourseName { get; set; }

        [DisplayName("Course Duration")]
        [Required]
        public string Duration { get; set; }
    }
}
