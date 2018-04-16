namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieDataTypeDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "RelDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "RecDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "RecDate", c => c.String(maxLength: 10));
            AlterColumn("dbo.Movies", "RelDate", c => c.String(maxLength: 10));
        }
    }
}
