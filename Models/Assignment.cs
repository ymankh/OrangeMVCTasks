using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrangeMVCTasks.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DuoDate { get; set; }
    }
}