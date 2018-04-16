namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnMovieTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Movies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Genre = c.String(),
                        RelDate = c.String(maxLength:10),
                        QOH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
