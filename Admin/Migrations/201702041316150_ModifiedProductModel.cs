namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitAvailable", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "UnitAvailabel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "UnitAvailabel", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "UnitAvailable");
        }
    }
}
