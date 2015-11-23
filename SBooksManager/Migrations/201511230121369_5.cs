namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CouponID", "dbo.Coupons");
            DropIndex("dbo.Orders", new[] { "CouponID" });
            DropPrimaryKey("dbo.Coupons");
            AddColumn("dbo.Coupons", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Coupons", "OrderThreshold", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Coupons", "CouponID", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Coupons", "CouponType", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "CouponID", c => c.String(maxLength: 20));
            AddPrimaryKey("dbo.Coupons", "CouponID");
            CreateIndex("dbo.Orders", "CouponID");
            AddForeignKey("dbo.Orders", "CouponID", "dbo.Coupons", "CouponID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CouponID", "dbo.Coupons");
            DropIndex("dbo.Orders", new[] { "CouponID" });
            DropPrimaryKey("dbo.Coupons");
            AlterColumn("dbo.Orders", "CouponID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Coupons", "CouponType", c => c.String(nullable: false));
            AlterColumn("dbo.Coupons", "CouponID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Coupons", "OrderThreshold");
            DropColumn("dbo.Coupons", "Discount");
            AddPrimaryKey("dbo.Coupons", "CouponID");
            CreateIndex("dbo.Orders", "CouponID");
            AddForeignKey("dbo.Orders", "CouponID", "dbo.Coupons", "CouponID");
        }
    }
}
