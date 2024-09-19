using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeMVCTasks.Models
{
    public class StudentDetail
    {
        public int StudentDetailId { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}