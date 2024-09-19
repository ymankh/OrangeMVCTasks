using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrangeMVCTasks.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public StudentDetail StudentDetail { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}