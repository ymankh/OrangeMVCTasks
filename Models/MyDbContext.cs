using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrangeMVCTasks.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public MyDbContext() : base("MyConnectionString")
        {
        }
    }
}