using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrangeMVCTasks.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public DateTime HiringDate { get; set; } = DateTime.Now;

        public ICollection<Course> Courses { get; set; }
    }
}