namespace Medicare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BuyProduct", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BuyProduct", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
