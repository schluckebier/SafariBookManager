namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        CouponID = c.String(nullable: false, maxLength: 128),
                        CouponType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CouponID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerEmail = c.String(nullable: false, maxLength: 128),
                        FName = c.String(nullable: false),
                        MI = c.String(),
                        LName = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false),
                        StreetAddress = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Zip = c.String(nullable: false),
                        CreditCard1 = c.String(nullable: false),
                        CreditCard1Type = c.String(),
                        CreditCard2 = c.String(),
                        CreditCard2Type = c.String(),
                        CardType = c.String(),
                        CustomerActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerEmail);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerEmail = c.String(maxLength: 128),
                        SKU = c.Int(nullable: false),
                        CouponID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Books", t => t.SKU, cascadeDelete: true)
                .ForeignKey("dbo.Coupons", t => t.CouponID)
                .ForeignKey("dbo.Customers", t => t.CustomerEmail)
                .Index(t => t.CustomerEmail)
                .Index(t => t.SKU)
                .Index(t => t.CouponID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        SKU = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AuthorFirst = c.String(),
                        AuthorLast = c.String(),
                        Genre = c.String(),
                        PublicationDate = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceLastPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discontinued = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Inventory = c.Int(nullable: false),
                        ReorderPoint = c.Int(nullable: false),
                        Review = c.String(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.SKU)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .Index(t => t.Order_OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerEmail", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CouponID", "dbo.Coupons");
            DropForeignKey("dbo.Books", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "SKU", "dbo.Books");
            DropIndex("dbo.Books", new[] { "Order_OrderID" });
            DropIndex("dbo.Orders", new[] { "CouponID" });
            DropIndex("dbo.Orders", new[] { "SKU" });
            DropIndex("dbo.Orders", new[] { "CustomerEmail" });
            DropTable("dbo.Books");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Coupons");
        }
    }
}
