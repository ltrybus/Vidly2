namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Killtables : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenreDescription_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreDescription_Id", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreDescription_Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreDescription_Id");
        }
    }
}
