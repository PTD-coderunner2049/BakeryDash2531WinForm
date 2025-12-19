namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Name");
        }
    }
}
