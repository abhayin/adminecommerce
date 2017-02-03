namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDisplayFieldDisplayStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DisplayStatus", "Display", c => c.Boolean(nullable: false));

        }
        
        public override void Down()
        {
            DropColumn("dbo.DisplayStatus", "Display");
        }
    }
}
