namespace Medicare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductType", "ProductTypeName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductType", "ProductTypeName", c => c.Int(nullable: false));
        }
    }
}
