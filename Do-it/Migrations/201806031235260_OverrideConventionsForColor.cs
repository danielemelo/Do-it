namespace Do_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForColor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Colors", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Colors", "RGB", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Colors", "RGB", c => c.String());
            AlterColumn("dbo.Colors", "Name", c => c.String());
        }
    }
}
