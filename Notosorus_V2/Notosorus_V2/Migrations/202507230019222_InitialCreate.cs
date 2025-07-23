namespace Notosorus_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Teacher = c.String(),
                        NbGroup = c.String(),
                        Semester_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Semesters", t => t.Semester_Id)
                .Index(t => t.Semester_Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Date = c.DateTime(nullable: false),
                        Classes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .Index(t => t.Classes_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grade = c.Int(nullable: false),
                        OutOf = c.Int(nullable: false),
                        Classes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .Index(t => t.Classes_Id);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Semester_Id", "dbo.Semesters");
            DropForeignKey("dbo.Grades", "Classes_Id", "dbo.Classes");
            DropForeignKey("dbo.Notes", "Classes_Id", "dbo.Classes");
            DropIndex("dbo.Grades", new[] { "Classes_Id" });
            DropIndex("dbo.Notes", new[] { "Classes_Id" });
            DropIndex("dbo.Classes", new[] { "Semester_Id" });
            DropTable("dbo.Semesters");
            DropTable("dbo.Grades");
            DropTable("dbo.Notes");
            DropTable("dbo.Classes");
        }
    }
}
