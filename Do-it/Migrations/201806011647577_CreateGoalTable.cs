namespace Do_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGoalTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Title = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            DropTable("dbo.Goals");
        }
    }
}
