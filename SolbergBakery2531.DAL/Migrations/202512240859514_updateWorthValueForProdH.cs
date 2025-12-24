namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateWorthValueForProdH : DbMigration
    {
        public override void Up()
        {
            // 1. Drop the existing computed column
            Sql("ALTER TABLE [dbo].[ProductHistories] DROP COLUMN [TotalWorth]");

            // 2. Add it back as a regular column (so your C# logic can save to it)
            // OR add it back as a new computed column.

            // RECOMMENDATION: Add as a regular column to support your C# IF/ELSE logic:
            AddColumn("dbo.ProductHistories", "TotalWorth", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            // To undo, drop it and add it back the way it was before
            Sql("ALTER TABLE [dbo].[ProductHistories] DROP COLUMN [TotalWorth]");
            Sql("ALTER TABLE [dbo].[ProductHistories] ADD [TotalWorth] AS ([ChangeQuantity] * ([SaleValue] - [ImportValue]))");
        }
    }
}
