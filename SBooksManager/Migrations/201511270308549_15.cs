namespace SBooksManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmpEmail = c.String(nullable: false),
                        EmpFName = c.String(nullable: false),
                        EmpMI = c.String(),
                        EmpLName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        EmpActive = c.Boolean(nullable: false),
                        ManagerID = c.String(),
                        ManEmail = c.String(),
                        ManFName = c.String(),
                        ManMI = c.String(),
                        ManLName = c.String(),
                        ManPassword = c.String(),
                        ManAddress = c.String(),
                        ManZipCode = c.String(),
                        ManPhone = c.String(),
                        ManActive = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            //CreateTable(
            //    "dbo.Reorders",
            //    c => new
            //        {
            //            ReorderID = c.Int(nullable: false, identity: true),
            //            EmployeeID = c.Int(nullable: false),
            //            SKU = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ReorderID)
            //    .ForeignKey("dbo.Books", t => t.SKU, cascadeDelete: true)
            //    .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
            //    .Index(t => t.EmployeeID)
            //    .Index(t => t.SKU);
            
            //DropColumn("dbo.Customers", "City");
            //DropColumn("dbo.Customers", "CardType");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Customers", "CardType", c => c.String());
            //AddColumn("dbo.Customers", "City", c => c.String(nullable: false));
            //DropForeignKey("dbo.Reorders", "EmployeeID", "dbo.Employees");
            //DropForeignKey("dbo.Reorders", "SKU", "dbo.Books");
            //DropIndex("dbo.Reorders", new[] { "SKU" });
            //DropIndex("dbo.Reorders", new[] { "EmployeeID" });
            //DropTable("dbo.Reorders");
            //DropTable("dbo.Employees");
        }
    }
}
