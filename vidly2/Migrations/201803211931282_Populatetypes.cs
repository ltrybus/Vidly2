namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populatetypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes set MembershipDescription = 'Pay as you go' WHERE Id = 1");
            Sql("UPDATE dbo.MembershipTypes set MembershipDescription = 'Weely' WHERE Id = 2");
            Sql("UPDATE dbo.MembershipTypes set MembershipDescription = 'Monthly' WHERE Id = 3");
            Sql("UPDATE dbo.MembershipTypes set MembershipDescription = 'Yearly' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
