namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovietoGenre2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreDescription_Id", c => c.Int());
            CreateIndex("dbo.Movies", "GenreDescription_Id");
            AddForeignKey("dbo.Movies", "GenreDescription_Id", "dbo.Genres", "Id");
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropForeignKey("dbo.Movies", "GenreDescription_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreDescription_Id" });
            DropColumn("dbo.Movies", "GenreDescription_Id");
        }
    }
}
