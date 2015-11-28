namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
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
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceLastPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inventory = c.Int(nullable: false),
                        ReorderPoint = c.Int(nullable: false),
                        Discontinued = c.Boolean(nullable: false),
                        Rating = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Review = c.String(),
                        Order_OrderID = c.Int(),
                        Promotion_PromotionID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SKU)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .ForeignKey("dbo.Promotions", t => t.Promotion_PromotionID)
                .Index(t => t.Order_OrderID)
                .Index(t => t.Promotion_PromotionID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Promotion_PromotionID", "dbo.Promotions");

            DropForeignKey("dbo.Books", "Order_OrderID", "dbo.Orders");

            DropIndex("dbo.Books", new[] { "Promotion_PromotionID" });
            DropIndex("dbo.Books", new[] { "Order_OrderID" });
            DropTable("dbo.Books");
        }
    }
}
