namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (GenreDescription) VALUES ('Action')");
            Sql("INSERT INTO dbo.Genres (GenreDescription) VALUES ('Comedy')");
            Sql("INSERT INTO dbo.Genres (GenreDescription) VALUES ('Family')");
            Sql("INSERT INTO dbo.Genres (GenreDescription) VALUES ('Romance')");
            Sql("INSERT INTO dbo.Genres (GenreDescription) VALUES ('Anime')");
        }
        
        public override void Down()
        {
        }
    }
}
