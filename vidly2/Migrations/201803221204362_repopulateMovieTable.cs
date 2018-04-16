namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Movies (Name, Genre,RelDate, QOH) VALUES ('Hangover','Comedy','05/05/2009', 4)");
            Sql("INSERT INTO dbo.Movies (Name, Genre,RelDate, QOH) VALUES ('Die Hard','Action','05/05/1988', 3)");
            Sql("INSERT INTO dbo.Movies (Name, Genre,RelDate, QOH) VALUES ('The Terminator','Action','05/05/1984', 6)");
            Sql("INSERT INTO dbo.Movies (Name, Genre,RelDate, QOH) VALUES ('Toy Story','Family','05/05/1995', 2)");
            Sql("INSERT INTO dbo.Movies (Name, Genre,RelDate, QOH) VALUES ('Titanic','Romance','05/05/1997', 3)");

        }

        public override void Down()
        {
        }
    }
}
