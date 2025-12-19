namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StaffHistories", "End", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StaffHistories", "End", c => c.DateTime(nullable: false));
        }
    }
}
