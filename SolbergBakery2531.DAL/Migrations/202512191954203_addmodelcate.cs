namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodelcate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductOpts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Option = c.String(nullable: false, maxLength: 300),
                        AssociatedProduct_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.AssociatedProduct_Id)
                .Index(t => t.AssociatedProduct_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Description = c.String(nullable: false, maxLength: 300),
                        Note = c.String(nullable: false, maxLength: 300),
                        AvailableDate = c.DateTime(nullable: false),
                        DiscontinueDate = c.DateTime(nullable: false),
                        Pricing = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CateID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProdCategories", t => t.CateID, cascadeDelete: true)
                .Index(t => t.CateID);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOpts", "AssociatedProduct_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "CateID", "dbo.ProdCategories");
            DropIndex("dbo.Products", new[] { "CateID" });
            DropIndex("dbo.ProductOpts", new[] { "AssociatedProduct_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductOpts");
            DropTable("dbo.ProdCategories");
        }
    }
}
