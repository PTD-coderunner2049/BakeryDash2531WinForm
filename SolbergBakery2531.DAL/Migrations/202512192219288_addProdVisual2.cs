namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdVisual2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductVisuals", "Id", "dbo.Products");
            DropIndex("dbo.ProductVisuals", new[] { "Id" });
            RenameColumn(table: "dbo.Products", name: "CateID", newName: "ProdCategoryId");
            RenameIndex(table: "dbo.Products", name: "IX_CateID", newName: "IX_ProdCategoryId");
            AddColumn("dbo.ProductVisuals", "ProductId", c => c.Guid(nullable: false));
            CreateIndex("dbo.ProductVisuals", "ProductId");
            AddForeignKey("dbo.ProductVisuals", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductVisuals", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductVisuals", new[] { "ProductId" });
            DropColumn("dbo.ProductVisuals", "ProductId");
            RenameIndex(table: "dbo.Products", name: "IX_ProdCategoryId", newName: "IX_CateID");
            RenameColumn(table: "dbo.Products", name: "ProdCategoryId", newName: "CateID");
            CreateIndex("dbo.ProductVisuals", "Id");
            AddForeignKey("dbo.ProductVisuals", "Id", "dbo.Products", "Id");
        }
    }
}
