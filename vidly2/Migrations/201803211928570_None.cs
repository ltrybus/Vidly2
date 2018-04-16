namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class None : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipDescription");
        }
    }
}
