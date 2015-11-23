namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.String(nullable: false, maxLength: 128),
                        SKU = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionID)
                .ForeignKey("dbo.Books", t => t.SKU, cascadeDelete: true)
                .Index(t => t.SKU);
            
            AddColumn("dbo.Books", "Promotion_PromotionID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Books", "Promotion_PromotionID");
            AddForeignKey("dbo.Books", "Promotion_PromotionID", "dbo.Promotions", "PromotionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Promotion_PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.Promotions", "SKU", "dbo.Books");
            DropIndex("dbo.Promotions", new[] { "SKU" });
            DropIndex("dbo.Books", new[] { "Promotion_PromotionID" });
            DropColumn("dbo.Books", "Promotion_PromotionID");
            DropTable("dbo.Promotions");
        }
    }
}
