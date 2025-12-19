namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodelcate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductOpts", "AssociatedProduct_Id", "dbo.Products");
            DropIndex("dbo.ProductOpts", new[] { "AssociatedProduct_Id" });
            DropTable("dbo.ProductOpts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductOpts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Option = c.String(nullable: false, maxLength: 300),
                        AssociatedProduct_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProductOpts", "AssociatedProduct_Id");
            AddForeignKey("dbo.ProductOpts", "AssociatedProduct_Id", "dbo.Products", "Id");
        }
    }
}
