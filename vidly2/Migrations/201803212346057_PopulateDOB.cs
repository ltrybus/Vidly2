namespace vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDOB : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Customers set DOB = '08/05/1999' WHERE Id = 1");
            Sql("UPDATE dbo.Customers set DOB = '05/05/1965' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
