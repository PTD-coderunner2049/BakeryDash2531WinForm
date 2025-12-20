namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class increaseStringLimitProductAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Products", "Note", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Note", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 300));
        }
    }
}
