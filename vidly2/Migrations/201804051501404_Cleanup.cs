namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cleanup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipDescription", c => c.String());
        }
    }
}
