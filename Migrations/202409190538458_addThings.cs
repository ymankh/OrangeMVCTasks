namespace OrangeMVCTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addThings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        StudentDetailId = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        Address = c.String(),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentDetailId)
                .ForeignKey("dbo.Students", t => t.StudentDetailId)
                .Index(t => t.StudentDetailId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CourseDescription = c.String(),
                        CourseType = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentDetails", "StudentDetailId", "dbo.Students");
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.StudentDetails", new[] { "StudentDetailId" });
            DropTable("dbo.Courses");
            DropTable("dbo.StudentDetails");
        }
    }
}
