namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdVisual : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductVisuals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VisualinByte = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductVisuals", "Id", "dbo.Products");
            DropIndex("dbo.ProductVisuals", new[] { "Id" });
            DropTable("dbo.ProductVisuals");
        }
    }
}
