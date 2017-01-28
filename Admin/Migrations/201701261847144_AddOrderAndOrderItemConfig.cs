namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderAndOrderItemConfig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Categories");
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        InvoiceNo = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId);
            
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Categories", "CategoryId");
            CreateIndex("dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Categories", "CategoryId", "dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "CategoryId", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "ProductId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Categories", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
            AddPrimaryKey("dbo.Categories", "CategoryId");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
