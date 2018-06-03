namespace Do_it.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateColorTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (1, 'aquamarine', '#7fffd4')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (2, 'blue', '#63b8ff')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (3, 'green', '#00cd66')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (4, 'pink', '#eea9b8')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (5, 'purple', '#9b30ff')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (6, 'red', '#ee0000')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (7, 'turquoise', '#00c5cd')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (8, 'violet', '#ff3e96')");
            Sql("INSERT INTO Colors (Id, Name, RGB) VALUES (9, 'white', '#fffafa')");
        }


        public override void Down()
        {
            Sql("DELETE FROM Colors WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8, 9");
        }
    }
}
