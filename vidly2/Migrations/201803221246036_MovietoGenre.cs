namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovietoGenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenresId");
        }
    }
}
