using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class CollectionDataModel
    {
        public List<Student> Student { get; set; }
        public List<Courses> Courses { get; set; }
    }
}
