namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnabledFieldToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Enabled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Enabled");
            DropColumn("dbo.Products", "Enabled");
            DropColumn("dbo.Categories", "Enabled");
        }
    }
}
