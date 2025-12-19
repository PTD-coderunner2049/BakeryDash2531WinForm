namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodelcate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProdCategories", "EngName", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProdCategories", "EngName");
        }
    }
}
