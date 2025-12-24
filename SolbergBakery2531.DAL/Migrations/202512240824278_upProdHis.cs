namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upProdHis : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE ProductHistories ADD TotalWorth AS (ChangeQuantity * (SaleValue - ImportValue))");
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductHistories", "TotalWorth");
        }
    }
}
