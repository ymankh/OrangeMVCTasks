using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeMVCTasks.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseType { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}