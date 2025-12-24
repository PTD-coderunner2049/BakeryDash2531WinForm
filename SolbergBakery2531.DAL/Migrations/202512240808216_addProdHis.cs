namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdHis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductHistories",
                c => new
                    {
                        ChangeId = c.Guid(nullable: false),
                        ChangeOccur = c.DateTime(nullable: false),
                        Source = c.String(nullable: false),
                        ChangeQuantity = c.Int(nullable: false),
                        ImportValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ChangeId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.StaffHistories", "Product_Id", c => c.Guid());
            CreateIndex("dbo.StaffHistories", "Product_Id");
            AddForeignKey("dbo.StaffHistories", "Product_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductHistories", "ProductId", "dbo.Products");
            DropForeignKey("dbo.StaffHistories", "Product_Id", "dbo.Products");
            DropIndex("dbo.StaffHistories", new[] { "Product_Id" });
            DropIndex("dbo.ProductHistories", new[] { "ProductId" });
            DropColumn("dbo.StaffHistories", "Product_Id");
            DropTable("dbo.ProductHistories");
        }
    }
}
