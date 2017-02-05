namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderStatusModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropPrimaryKey("dbo.Orders");
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            AddColumn("dbo.Orders", "StatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Orders", "OrderId");
            CreateIndex("dbo.Orders", "OrderId");
            AddForeignKey("dbo.Orders", "OrderId", "dbo.OrderStatus", "StatusId");
            AddForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
            DropColumn("dbo.Orders", "Status");

            Sql("INSERT INTO OrderStatus (Status) VALUES('Pending')");
            Sql("INSERT INTO OrderStatus (Status) VALUES('Dispatch')");
            Sql("INSERT INTO OrderStatus (Status) VALUES('Delivered')");

        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Status", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "OrderId", "dbo.OrderStatus");
            DropIndex("dbo.Orders", new[] { "OrderId" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Orders", "StatusId");
            DropTable("dbo.OrderStatus");
            AddPrimaryKey("dbo.Orders", "OrderId");
            AddForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
        }
    }
}
