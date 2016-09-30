namespace Medicare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyProduct",
                c => new
                    {
                        BuyProductId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        OrderNumber = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BillDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BuyProductId)
                .ForeignKey("dbo.Order", t => t.OrderId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        SalesTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ErrorLog = c.String(),
                        ErrorMessage = c.String(),
                        PaidStatus = c.Boolean(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Payment", t => t.PaymentId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.PaymentId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PaymentType = c.String(),
                        Allowed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        MobileNo = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        ConfirmPassword = c.String(),
                        Email = c.String(),
                        CreditCard = c.String(),
                        DateOfEnterence = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductQuantityperUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EntryDate = c.DateTime(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        Picture = c.String(),
                        BatchNo = c.String(),
                        Groups_GroupsId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Manufacturar", t => t.ManufacturerId)
                .ForeignKey("dbo.ProductType", t => t.ProductTypeId)
                .ForeignKey("dbo.Groups", t => t.Groups_GroupsId)
                .Index(t => t.ProductTypeId)
                .Index(t => t.ManufacturerId)
                .Index(t => t.Groups_GroupsId);
            
            CreateTable(
                "dbo.Manufacturar",
                c => new
                    {
                        ManufacturerId = c.Int(nullable: false, identity: true),
                        ManufacturarName = c.String(),
                        CompanyDetails = c.String(),
                    })
                .PrimaryKey(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        ProductTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupsId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.GroupsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Groups_GroupsId", "dbo.Groups");
            DropForeignKey("dbo.Product", "ProductTypeId", "dbo.ProductType");
            DropForeignKey("dbo.Product", "ManufacturerId", "dbo.Manufacturar");
            DropForeignKey("dbo.BuyProduct", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Order", "UserId", "dbo.User");
            DropForeignKey("dbo.Order", "PaymentId", "dbo.Payment");
            DropForeignKey("dbo.BuyProduct", "OrderId", "dbo.Order");
            DropIndex("dbo.Product", new[] { "Groups_GroupsId" });
            DropIndex("dbo.Product", new[] { "ManufacturerId" });
            DropIndex("dbo.Product", new[] { "ProductTypeId" });
            DropIndex("dbo.Order", new[] { "PaymentId" });
            DropIndex("dbo.Order", new[] { "UserId" });
            DropIndex("dbo.BuyProduct", new[] { "ProductId" });
            DropIndex("dbo.BuyProduct", new[] { "OrderId" });
            DropTable("dbo.Groups");
            DropTable("dbo.ProductType");
            DropTable("dbo.Manufacturar");
            DropTable("dbo.Product");
            DropTable("dbo.User");
            DropTable("dbo.Payment");
            DropTable("dbo.Order");
            DropTable("dbo.BuyProduct");
        }
    }
}
