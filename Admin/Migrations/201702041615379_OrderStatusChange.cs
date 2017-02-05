namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderStatusChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "Enabled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Enabled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "Status");
        }
    }
}
