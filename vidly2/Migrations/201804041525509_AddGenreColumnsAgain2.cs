namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreColumnsAgain2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenresId");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenresId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenresId" });
            DropColumn("dbo.Movies", "GenresId");
        }
    }
}
