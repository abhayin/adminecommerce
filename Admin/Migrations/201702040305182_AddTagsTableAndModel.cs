namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTagsTableAndModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        TagName = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TagId)
                .ForeignKey("dbo.Products", t => t.TagId)
                .Index(t => t.TagId);
            
            AddColumn("dbo.Products", "TagId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "TagId", "dbo.Products");
            DropIndex("dbo.Tags", new[] { "TagId" });
            DropColumn("dbo.Products", "TagId");
            DropTable("dbo.Tags");
        }
    }
}
