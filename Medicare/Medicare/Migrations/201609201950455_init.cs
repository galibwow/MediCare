namespace Medicare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Product", new[] { "Manufacturar_ManufacturerId" });
            RenameColumn(table: "dbo.Product", name: "Manufacturar_ManufacturerId", newName: "ManufacturerId");
            AlterColumn("dbo.Product", "ManufacturerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "ManufacturerId");
            DropColumn("dbo.Product", "ManufacturarId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "ManufacturarId", c => c.Int(nullable: false));
            DropIndex("dbo.Product", new[] { "ManufacturerId" });
            AlterColumn("dbo.Product", "ManufacturerId", c => c.Int());
            RenameColumn(table: "dbo.Product", name: "ManufacturerId", newName: "Manufacturar_ManufacturerId");
            CreateIndex("dbo.Product", "Manufacturar_ManufacturerId");
        }
    }
}
