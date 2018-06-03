namespace Do_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGoalTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        RGB = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Title = c.String(nullable: false, maxLength: 255),
                        Color_Id = c.Byte(nullable: false),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Color_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Goals", "Color_Id", "dbo.Colors");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            DropIndex("dbo.Goals", new[] { "Color_Id" });
            DropTable("dbo.Goals");
            DropTable("dbo.Colors");
        }
    }
}
