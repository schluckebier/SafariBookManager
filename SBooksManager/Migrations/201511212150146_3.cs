namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CouponCode", "dbo.Coupons");
            RenameColumn(table: "dbo.Orders", name: "CouponCode", newName: "CouponID");
            RenameIndex(table: "dbo.Orders", name: "IX_CouponCode", newName: "IX_CouponID");
            DropPrimaryKey("dbo.Coupons");
            AddColumn("dbo.Coupons", "CouponID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Coupons", "CouponID");
            AddForeignKey("dbo.Orders", "CouponID", "dbo.Coupons", "CouponID");
            DropColumn("dbo.Coupons", "CouponCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coupons", "CouponCode", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Orders", "CouponID", "dbo.Coupons");
            DropPrimaryKey("dbo.Coupons");
            DropColumn("dbo.Coupons", "CouponID");
            AddPrimaryKey("dbo.Coupons", "CouponCode");
            RenameIndex(table: "dbo.Orders", name: "IX_CouponID", newName: "IX_CouponCode");
            RenameColumn(table: "dbo.Orders", name: "CouponID", newName: "CouponCode");
            AddForeignKey("dbo.Orders", "CouponCode", "dbo.Coupons", "CouponCode");
        }
    }
}
