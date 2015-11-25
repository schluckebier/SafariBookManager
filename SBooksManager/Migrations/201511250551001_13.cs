namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coupons", "OrderThreshold", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Coupons", "Discount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coupons", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Coupons", "OrderThreshold", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
