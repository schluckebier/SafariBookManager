namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coupons", "FreeShipIf", c => c.Boolean(nullable: false));
            AddColumn("dbo.Coupons", "FreeShipAll", c => c.Boolean(nullable: false));
            AddColumn("dbo.Coupons", "DiscountTotal", c => c.Boolean(nullable: false));
            DropColumn("dbo.Coupons", "CouponType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coupons", "CouponType", c => c.Int(nullable: false));
            DropColumn("dbo.Coupons", "DiscountTotal");
            DropColumn("dbo.Coupons", "FreeShipAll");
            DropColumn("dbo.Coupons", "FreeShipIf");
        }
    }
}
