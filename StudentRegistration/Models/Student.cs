using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        [Required]
        public DateTime DOB { get; set; }

        [DisplayName("Email Address")]
        [Required]
        public string Email { get; set; }

        [DisplayName("NIC Number")]
        [Required]
        public string NIC { get; set; }

        [DisplayName("Contact Number")]
        [Required]
        public string Contact { get; set; }

        [DisplayName("Digree Program")]
        [Required]
        public string Digree { get; set; }
    }
}
