namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuantityProd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "quantityInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "quantityInStock");
        }
    }
}
