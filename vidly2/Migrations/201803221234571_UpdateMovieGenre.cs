namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Movies set Genre= 2 where Genre = 'Comedy'");
            Sql("UPDATE dbo.Movies set Genre= 1 where Genre = 'Action'");
            Sql("UPDATE dbo.Movies set Genre= 3 where Genre = 'Family'");
            Sql("UPDATE dbo.Movies set Genre= 4 where Genre = 'Romance'");
        }
        
        public override void Down()
        {
        }
    }
}
