namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKConstraint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "CategoryId", "dbo.Products");
            DropIndex("dbo.Categories", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Categories");
            AddColumn("dbo.Products", "UnitAvailabel", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductImage", c => c.String());
            AddColumn("dbo.Products", "DisplayStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "CategoryId");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Products", "MyProperty");
            DropColumn("dbo.Products", "Enabled");

            Sql("INSERT INTO Categories (CategoryName) VALUES('Food')");
            Sql("INSERT INTO Categories (CategoryName) VALUES('Vegetables')");
            Sql("INSERT INTO Categories (CategoryName) VALUES('Grocery')");

        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "MyProperty", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "DisplayStatus");
            DropColumn("dbo.Products", "ProductImage");
            DropColumn("dbo.Products", "UnitAvailabel");
            AddPrimaryKey("dbo.Categories", "CategoryId");
            CreateIndex("dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Categories", "CategoryId", "dbo.Products", "ProductId");
        }
    }
}
