namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatetimeFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderPlacedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "OrderDeliveredDate", c => c.DateTime());
            AddColumn("dbo.Products", "ProductAddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "ProductModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductModifiedDate");
            DropColumn("dbo.Products", "ProductAddedDate");
            DropColumn("dbo.Orders", "OrderDeliveredDate");
            DropColumn("dbo.Orders", "OrderPlacedDate");
        }
    }
}
