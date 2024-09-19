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
        public DbSet<StudentDetail> StudentDetail { get; set; }
        public DbSet<Course> Courses { get; set; }

        public MyDbContext() : base("MyConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // One-to-One relationship
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.StudentDetail)
                .WithRequired(sd => sd.Student);

            base.OnModelCreating(modelBuilder);
        }
    }
}