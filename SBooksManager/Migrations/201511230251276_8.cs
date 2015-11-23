namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CardType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CardType", c => c.String());
        }
    }
}
