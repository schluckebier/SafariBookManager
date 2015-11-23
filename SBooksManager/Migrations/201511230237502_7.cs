namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "City", c => c.String(nullable: false));
        }
    }
}
