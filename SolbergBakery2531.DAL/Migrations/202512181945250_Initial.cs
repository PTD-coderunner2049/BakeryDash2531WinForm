namespace SolbergBakery2531.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductOpts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Option = c.String(nullable: false, maxLength: 300),
                        AssociatedProduct_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.AssociatedProduct_Id)
                .Index(t => t.AssociatedProduct_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductGlobalId = c.Guid(nullable: false),
                        Description = c.String(nullable: false, maxLength: 300),
                        Note = c.String(nullable: false, maxLength: 300),
                        AvailableDate = c.DateTime(nullable: false),
                        DiscontinueDate = c.DateTime(nullable: false),
                        Pricing = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaffHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Ongoing = c.Boolean(nullable: false),
                        HR_Feedback = c.String(),
                        StaffId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneContact = c.String(nullable: false, maxLength: 15),
                        Gender = c.String(nullable: false, maxLength: 1),
                        Birth = c.DateTime(nullable: false),
                        SSN = c.String(nullable: false, maxLength: 11),
                        PayratePerHrs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        IsSystemManager = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true)
                .Index(t => t.PhoneContact, unique: true)
                .Index(t => t.SSN, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        PasswordHash = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Username, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Id", "dbo.Staffs");
            DropForeignKey("dbo.StaffHistories", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.ProductOpts", "AssociatedProduct_Id", "dbo.Products");
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Users", new[] { "Id" });
            DropIndex("dbo.Staffs", new[] { "SSN" });
            DropIndex("dbo.Staffs", new[] { "PhoneContact" });
            DropIndex("dbo.Staffs", new[] { "Email" });
            DropIndex("dbo.StaffHistories", new[] { "StaffId" });
            DropIndex("dbo.ProductOpts", new[] { "AssociatedProduct_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Staffs");
            DropTable("dbo.StaffHistories");
            DropTable("dbo.Products");
            DropTable("dbo.ProductOpts");
        }
    }
}
