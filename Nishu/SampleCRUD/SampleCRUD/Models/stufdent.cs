using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleCRUD.Models
{
    public class stufdent
    {
        public String Name { get; set; }
        [Key]
        public String ID { get; set; }
        public int Age { get; set; }
    }
}