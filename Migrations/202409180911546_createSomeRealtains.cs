namespace OrangeMVCTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSomeRealtains : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "Student_StudentId", c => c.Int());
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 150));
            CreateIndex("dbo.Assignments", "Student_StudentId");
            AddForeignKey("dbo.Assignments", "Student_StudentId", "dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.Assignments", new[] { "Student_StudentId" });
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Assignments", "Student_StudentId");
        }
    }
}
